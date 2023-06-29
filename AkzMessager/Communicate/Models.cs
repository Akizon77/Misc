using System;

namespace Communicate
{
    public class Models
    {
        public class Message
        {
            public int Id { get; set; }//ID
            public int Sender { get; set; }//发送消息的用户ID
            public int Reci { get; set; }//接受消息的用户ID
            public DateTime Date { get; set; }//时间
            public Content Content { get; set; }//内容

        }


        public class Image
        {
            public int Id { get; set; }
            public string Path { get; set; }


        }

        public class Session
        {
            public string Content { get; set; }
        }
        public class Content
        {
            public Image? picture;
            public string? text;
            Content(Image image)
            {
                picture = image;
            }
            Content(string text)
            {
                this.text = text;
            }
            Content(Image picture, string text)
            {
                this.picture = picture;
                this.text = text;
            }
        }
    }
}