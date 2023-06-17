#include <stdio.h>

#define LEFT_COLS 35
#define RIGHT_COLS 35
#define LINES_PER_SCREEN 20

int main() {
    FILE *file1 = fopen("file1.txt", "r");
    FILE *file2 = fopen("file2.txt", "r");
    
    if (!file1 || !file2) {
        printf("Error opening files.\n");
        return 1;
    }

    char line1[LEFT_COLS], line2[RIGHT_COLS];
    int line_count = 0;

    while (1) {
        int count = 0;

        for (int i = 0; i < LINES_PER_SCREEN; i++) {
            char *status1 = fgets(line1, LEFT_COLS, file1);
            char *status2 = fgets(line2, RIGHT_COLS, file2);

            if (!status1 && !status2) {
                return 0; // Both files have reached the end
            }

            printf("%-34.34s    %-34.34s    %d\n", 
                   status1 ? line1 : "", 
                   status2 ? line2 : "", 
                   ++line_count);

            if (status1 || status2) {
                count++;
            }
        }

        if (count == 0) {
            break; // Both files have reached the end
        }

        printf("\nPress enter to continue...");
        getchar();
    }

    fclose(file1);
    fclose(file2);
    return 0;
}
