using Newtonsoft.Json.Linq;
using SharpNBT;
using SharpNBT.SNBT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        string input =
          "{\r\n\tid: \"56C30AAD66E38A2B\"\r\n\tgroup: \"11F74EE62D2AB5DF\"\r\n\torder_index: 1\r\n\tfilename: \"bosses\"\r\n\ttitle: \"&6Bosses\"\r\n\ticon: \"artifacts:fire_gauntlet\"\r\n\tdefault_quest_shape: \"\"\r\n\tdefault_hide_dependency_lines: false\r\n\timages: [\r\n\t\t{\r\n\t\t\tx: 0.1785714285714306d\r\n\t\t\ty: -4.446428571428569d\r\n\t\t\twidth: 5.0d\r\n\t\t\theight: 2.0d\r\n\t\t\trotation: 0.0d\r\n\t\t\timage: \"kubejs:textures/item/boss.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: 0.1071428571428612d\r\n\t\t\ty: -3.017857142857146d\r\n\t\t\twidth: 1.9d\r\n\t\t\theight: 2.7d\r\n\t\t\trotation: 0.0d\r\n\t\t\timage: \"kubejs:textures/item/skull.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: 1.5357142857142847d\r\n\t\t\ty: -1.5178571428571388d\r\n\t\t\twidth: 1.0d\r\n\t\t\theight: 2.0d\r\n\t\t\trotation: 90.0d\r\n\t\t\timage: \"kubejs:textures/item/firef.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: -1.5d\r\n\t\t\ty: -1.5d\r\n\t\t\twidth: 1.0d\r\n\t\t\theight: 2.0d\r\n\t\t\trotation: -90.0d\r\n\t\t\timage: \"kubejs:textures/item/fire.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: 8.5d\r\n\t\t\ty: 1.0d\r\n\t\t\twidth: 3.2d\r\n\t\t\theight: 4.1d\r\n\t\t\trotation: 0.0d\r\n\t\t\timage: \"kubejs:textures/item/skeletonf.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: -8.5d\r\n\t\t\ty: 1.0d\r\n\t\t\twidth: 3.2d\r\n\t\t\theight: 4.1d\r\n\t\t\trotation: 0.0d\r\n\t\t\timage: \"kubejs:textures/item/skeleton.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: 0.0d\r\n\t\t\ty: 1.5d\r\n\t\t\twidth: 2.3d\r\n\t\t\theight: 5.0d\r\n\t\t\trotation: -2.0d\r\n\t\t\timage: \"kubejs:textures/item/firswo.png\"\r\n\t\t\thover: [ ]\r\n\t\t\tclick: \"\"\r\n\t\t\tdev: false\r\n\t\t\tcorner: false\r\n\t\t}\r\n\t]\r\n\tquests: [\r\n\t\t{\r\n\t\t\ticon: \"minecraft:dragon_head\"\r\n\t\t\tx: 2.0d\r\n\t\t\ty: -2.5d\r\n\t\t\tshape: \"square\"\r\n\t\t\tsubtitle: \"末影龙是进入末地时发现的巨大的飞行敌对Boss。她是游戏中最大的自然生成的生物，被广泛认为是&b&oMinecraft的最终Boss。\"\r\n\t\t\tsize: 1.3d\r\n\t\t\tid: \"045A7C6A2B0E8D9D\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4989CF445E225FF4\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"minecraft:dragon_egg\"\r\n\t\t\t\t\tentity: \"minecraft:ender_dragon\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6BBCC82D0F7AC9A4\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4FF2FEAA873FE8DF\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 7643435528041904640L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4E224BCC4CF30D26\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/undead_king.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -5.5d\r\n\t\t\ty: 3.0d\r\n\t\t\tsubtitle: \"&l不死之王&r是一个Boss，需要召唤才能出现。\"\r\n\t\t\tdescription: [\"通过在T形状中放置4个&l&o&6腐烂方块&r，并在中间放置一个&l&o&6僵尸头&r来召唤不会自然生成的Boss &l不死之王&r。\"]\r\n\t\t\tid: \"4A24ADBA201B3BCA\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"750BD1B87B9604A4\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"zombiearmy:undeadking_spawn_egg\"\r\n\t\t\t\t\tentity: \"zombiearmy:undeadking\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5778CE473471A560\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"340D305FC7CA0BD8\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0CF067949786A38C\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"alexsmobs:mysterious_worm\"\r\n\t\t\tx: -6.5d\r\n\t\t\ty: 3.0d\r\n\t\t\tid: \"76F050E836FA5A71\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"40E6D68371EC8AFA\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"alexsmobs:void_worm\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"29EABF32121D3270\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"406117454BC8C557\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 687554054301909623L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"589C59E3F7C64ABB\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/cyclops.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -4.5d\r\n\t\t\ty: 0.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"独眼巨人是在大型石洞内照顾羊群的迷你Boss。\"\r\n\t\t\tid: \"201801F247481FB8\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"457FF445E3E93381\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_cyclops\"\r\n\t\t\t\t\tentity: \"iceandfire:cyclops\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"17C461228AA0A882\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"37367109D82A498B\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6813199617749196115L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"17FD29498EC694E6\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"mowziesmobs:barako_mask\"\r\n\t\t\tx: -2.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"Barako是Barakoa部落的首领，坐落在Barakoa村庄的宝座上。他从太阳中汲取力量，召唤太阳打击、太阳耀斑和巨大的太阳光束。\"\r\n\t\t\tdescription: [\"然而，足够强大以面对并击败他的人将获得他的面具：太阳面容。这个面具允许佩戴者为面具注入生命，创造巴拉科亚追随者。\"]\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"24FD9711A8E9864E\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5622994E9B61538C\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"mowziesmobs:barako_spawn_egg\"\r\n\t\t\t\t\tentity: \"mowziesmobs:barako\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7752C5EFAB52A5A8\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 500\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7075A1EE80F8B41F\"\r\n\t\t\t\t\ttype: \"item\"\r\n\t\t\t\t\titem: \"minecraft:gold_block\"\r\n\t\t\t\t\tcount: 25\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1B5B3EC8DECEDEB0\"\r\n\t\t\t\t\ttype: \"item\"\r\n\t\t\t\t\titem: \"minecraft:golden_apple\"\r\n\t\t\t\t\tcount: 16\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3E8B441C1D27EC1F\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"mowziesmobs:wrought_helmet\"\r\n\t\t\tx: -2.0d\r\n\t\t\ty: 1.0d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"多年前失落在地下的这些重装骑士既不是人也不是雕像。他们在守卫着什么？只有最勇敢的冒险家才敢挑战铁锻巨人。\"\r\n\t\t\tdescription: [\"在击败后，铁锻巨人将为胜利者掉落其铁锻头盔和千金金属之斧。右键使用斧头可以攻击一个大范围，按住Shift+右键会创建一个震荡波，将目标拉近你。\"]\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"342D61363208BECA\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2F63A50C53CB2031\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"mowziesmobs:wroughtnaut_spawn_egg\"\r\n\t\t\t\t\tentity: \"mowziesmobs:ferrous_wroughtnaut\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3319AC075AB84AAB\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"68F80A4C89072004\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 687554054301909623L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5FB0B4AD4CC942FD\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/elder_guardian.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -2.0d\r\n\t\t\ty: -2.5d\r\n\t\t\tshape: \"square\"\r\n\t\t\tsubtitle: \"远古守卫者是守卫者的更强大、更大的变种，可以造成挖掘疲劳。三个远古守卫者在海洋碑文中生成；一个在顶层房间，一个在每个翼中。\"\r\n\t\t\tsize: 1.3d\r\n\t\t\tid: \"32BDEB2C50FB1D9F\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"08FA9CD1FCA05B6E\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"minecraft:elder_guardian_spawn_egg\"\r\n\t\t\t\t\tentity: \"minecraft:elder_guardian\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"151745CF00069052\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"78B893FAA77BDBBD\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6813199617749196115L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"450ED2138BE4E190\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"mowziesmobs:ice_crystal\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tDamage: 0\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -2.0d\r\n\t\t\ty: 2.5d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"Frostmaws是在雪地区很少见的危险野兽。它们巨大的体型、惊人的速度和强大的冰息使它们成为几乎不可能的对手。如果在旅行中遇到一只睡在你路上的Frostmaws，最好选择另一条路线并让它躺下。\"\r\n\t\t\tdescription: [\"这只野兽守护着一颗珍贵的冰晶，当使用时可以释放纯净的冬季能量。\"]\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"05C7DF310A6EB8F6\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"158F056729EED689\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"mowziesmobs:frostmaw\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"475C18A838E7DA37\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2D0C2A5914510690\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6813199617749196115L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4118ABAACE75004B\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"xreliquary:twilight_cloak\"\r\n\t\t\tx: 2.0d\r\n\t\t\ty: 1.0d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"吸血鬼男爵可以从1-5级生成，但使用吸血鬼书在5级男爵上可以创建6级男爵。在杀死男爵时可以获得用于猎人和吸血鬼路径升级的纯血。血液的纯度取决于男爵的级别（1级男爵掉落纯度1/5，2级男爵掉落纯度2/5等等）。\"\r\n\t\t\tdescription: [\"**仅在&b&l吸血鬼森林**中发现\"]\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"47639DAAB95980B3\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4A8B4B1309D2C304\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"vampirism:vampire_baron\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5C2B225037226CA0\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"168F393C8AD9DC18\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 3168213399534062586L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"550011B84F7B6ECD\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4915960327715244389L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1B476585C3C830AF\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 687554054301909623L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"27DE4BD7316B24B1\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"botania:gaia_head\"\r\n\t\t\tx: 2.0d\r\n\t\t\ty: 2.5d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"Gaia Guardian是Botania中的敌对首领。它具有玩家的外观，尽管颜色要暗得多。\"\r\n\t\t\tdescription: [\r\n\t\t\t\t\"它有大约200点生命值和未知的伤害；然而，生命值和伤害会根据竞技场中玩家的数量而倍增。有两个玩家时，生命值为600。这是一个非常难以击败的危险首领；这是由于Guardian极其频繁的传送，几乎总是在你攻击它后传送，并释放Gaia陷阱。\"\r\n\t\t\t\t\"\"\r\n\t\t\t\t\"**必须召唤**\"\r\n\t\t\t]\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"44CFA46C0F128BD9\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"499443CB235423E7\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"botania:gaia_head\"\r\n\t\t\t\t\tentity: \"botania:doppleganger\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"34562A784D23CE01\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"285D9E18170D3FFD\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7D399986F8008335\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 7643435528041904640L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7DFA5384434B77DA\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/sea_serpent.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -6.5d\r\n\t\t\ty: -1.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"海蛇是凶猛的爬行海洋掠食者，恐吓着广阔的海洋并攻击任何它看到的较小生物。\"\r\n\t\t\tid: \"636C095182CE8FE5\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"66BE95AD749F5F01\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_sea_serpent\"\r\n\t\t\t\t\tentity: \"iceandfire:sea_serpent\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5FBC84DD0EB40B85\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"244B065767911D7E\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6813199617749196115L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3C812A5DEFC8693D\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/gorgon.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -5.5d\r\n\t\t\ty: -1.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"蛇发女妖是潜伏在沿海地下巢穴中的迷你首领，用凝视石化的目光杀死任何看着它们的东西。\"\r\n\t\t\tid: \"4766EE685D8407AE\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"39F892207DD104EC\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_gorgon\"\r\n\t\t\t\t\tentity: \"iceandfire:gorgon\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4D004193EA56174D\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"349E997F19A0F582\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 7643435528041904640L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"754ED4ACCFE9DCBA\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/myrmex.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -4.5d\r\n\t\t\ty: -1.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"Myrmex是脾气暴躁的节肢动物，居住在地下蜂巢中并维护一个复杂的等级制度。\"\r\n\t\t\tid: \"077E8759B09E3490\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"160461D2724A9456\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_myrmex_queen\"\r\n\t\t\t\t\tentity: \"iceandfire:myrmex_queen\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"37362B6B90517D49\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5200929724818311\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6813199617749196115L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4E2B02B873A1B691\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/troll.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -5.5d\r\n\t\t\ty: 0.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"巨魔是丑陋的野兽，藏在洞穴中，无情地殴打任何探险者寻找矿石。\"\r\n\t\t\tid: \"178B83D6E6C33A06\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"397B952C7AAA3C6E\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_troll\"\r\n\t\t\t\t\tentity: \"iceandfire:troll\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"681AFAC015F401BB\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"29562D04E8F89080\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4B342651FD2BCA25\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/fire_dragon.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -7.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"火龙是在Overworld漫游的三种龙之一。它们以致命的火焰和飞行能力以及强大的声望而闻名。\"\r\n\t\t\tdescription: [\"火龙有九种自然攻击方式，所有这些方式都可以轻松地消灭玩家。此外，它们通过五个发展阶段，变得更大、更强大和更可怕。\"]\r\n\t\t\tid: \"274B0E0DC3E6BBCE\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"382364AFF94B1B67\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_fire_dragon\"\r\n\t\t\t\t\tentity: \"iceandfire:fire_dragon\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5846943787A69562\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"227B6576EFA8F566\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"71B6AC19DEDAF195\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/ice_dragon.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -6.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"冰龙是在Overworld漫游的三种龙之一。它们以呼吸冰冷的气息而闻名。\"\r\n\t\t\tdescription: [\"它们擅长于陆地、空中和水中。像火龙一样，冰龙也有几种可怕的攻击方式，可以在几秒钟内结束玩家。它们还通过五个发展阶段，变得更大、更强大和更可怕。\"]\r\n\t\t\tid: \"40290067C8657D68\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2A3037FF9421199C\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_ice_dragon\"\r\n\t\t\t\t\tentity: \"iceandfire:ice_dragon\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"173BCA704437B493\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1F197E6CDA38318A\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2C731FA59B9A874C\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/lightning_dragon.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -5.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"闪电龙是在Overworld漫游的三种龙之一。它们以喷出闪电流和飞行能力而闻名。\"\r\n\t\t\tdescription: [\"像火龙和冰龙一样，闪电龙有九种自然攻击方式，可以轻松地消灭玩家。它们还通过五个发展阶段，变得更大、更强大和更可怕。\"]\r\n\t\t\tid: \"02345E03CFA88DB0\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6311A1F7FFE46980\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_lightning_dragon\"\r\n\t\t\t\t\tentity: \"iceandfire:lightning_dragon\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6136EB4241532F80\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3ABD248131C10E5D\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1F7704A9B5F15C89\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/hydra.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -4.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"Hydras是迷你BOSS，用致命的毒液杀死猎物，并在其头部被切断时再生。\"\r\n\t\t\tid: \"6972C23D79B5B721\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5FA37D78AD0265B7\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_hydra\"\r\n\t\t\t\t\tentity: \"iceandfire:hydra\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"45AC736E9AABFE93\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"596C3415FA9B095D\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"03630C2A4CF238D1\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/amphithere.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -6.5d\r\n\t\t\ty: 0.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"Amphitheres是神秘的有羽毛的蛇，翱翔于茂密的丛林中，可以被驯服成快速飞行的坐骑。\"\r\n\t\t\tid: \"723F961D01C956D0\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1FB7EA524BB0A95B\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"iceandfire:spawn_egg_amphithere\"\r\n\t\t\t\t\tentity: \"iceandfire:amphithere\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1E6C2115B47CD8D2\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5C5707515BA5DF5C\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5DBBA55FE78FAEC0\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:minoshroom_trophy\"\r\n\t\t\tx: 5.5d\r\n\t\t\ty: -1.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"Minoshroom是在迷宫底部的监狱中潜伏的迷你BOSS。Minoshroom是Mooshroom和Centaur的奇异混合体。\"\r\n\t\t\tid: \"558ADEA5E26F17D2\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2802F6F501010818\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:minoshroom_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:minoshroom\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"08550B5E20016DBA\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"447DB46A4A6C0600\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6468877635738169977L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"23EB77CFFDA5A09A\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7782E042B681565E\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:knight_phantom_trophy\"\r\n\t\t\tx: 6.5d\r\n\t\t\ty: -1.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"骑士幽灵居住在哥布林骑士要塞的砖层房间里。它们看起来像幽灵般的幻影盔甲，攻击时看起来有点可怕。\"\r\n\t\t\tid: \"73A3AEB690FDE4F1\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"647C43DBAC44D8B6\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:knight_phantom_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:knight_phantom\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1020D524A23C8D2E\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"48184019999CDF0B\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4248343337893973070L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2F7025D0A92AC60A\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1FB4914FF03E6B93\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:snow_queen_trophy\"\r\n\t\t\tx: 5.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"雪女在奥罗拉宫殿附近的覆盖冰的房间里发现。她可能是在暮色森林中遇到的最像人类的生物，长得像一个女人，但有着大大的紫色眼睛和苍白的蓝色皮肤。她对任何入侵者都是立即敌对的，迅速进入三种主要攻击模式之一。\"\r\n\t\t\tid: \"57836DD0A7A3D6C3\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"704CE93F993B2DC6\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:snow_queen_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:snow_queen\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"54FA4F2A49286B3C\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0E56A8D8E9C9F0FC\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 2136994266140185172L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6590204C084DC820\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2D004CD0C9F4EC90\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:ur_ghast_trophy\"\r\n\t\t\tx: 6.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"Ur-Ghast可以在巨大的黑暗塔顶部飞行。它看起来像一个巨大的超自然生物，有许多大而摇曳的触手。它被覆盖着冒险家们害怕的血液，或者可能是Carminite。这个生物类似于Carminite Ghastguard，因为它们能够跟踪玩家，以及地狱专属的Ghasts，但它更大，更危险。\"\r\n\t\t\tid: \"786087BA5C725188\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"73FCFD4719D7F0F2\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:ur_ghast_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:ur_ghast\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"21BBB1FA13DDE5E0\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"64FD44979A62122D\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 8533451183250182354L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"43CAFBE211E55D26\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1E9269662E29D920\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:hydra_trophy\"\r\n\t\t\tx: 7.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"Hydra可以在火焰沼泽中独特的裂开的Hydra巢穴中找到。Hydra看起来像一个巨大的生物，有两条短腿支撑着宽阔的鳞片身体。多条蛇形脖子以大火头结束。\"\r\n\t\t\tid: \"09039B021F97E728\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"71C0713B696A130E\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:hydra_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:hydra\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1B2BA45739CEF3F1\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"383FF2684A60FA78\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 1375643567800692047L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"23A2EDD8636AAD38\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2E3A9F58689533FB\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:lich_trophy\"\r\n\t\t\tx: 4.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tsubtitle: \"暮色巫师居住在巫师塔的顶部。它看起来像一个穿着紫色披风和大金色皇冠的高大人形骨架。周围是一堵盾牌墙，以保护自己免受任何伤害，但也许它们可以被打破。\"\r\n\t\t\tid: \"5F41CE55D1C492A0\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3F8D499D1AD1089D\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"twilightforest:lich\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"24AEA87F77075CB4\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"00911BE820899F14\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4915960327715244389L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0F307E03A877C743\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"60E7DD868BD9DBD2\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:naga_trophy\"\r\n\t\t\tx: 4.5d\r\n\t\t\ty: -1.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"Naga是潜伏在Naga庭院中的蛇。它看起来像一个巨大的绿色蛇形生物，有一个类似人类的脸。它的鳞片有各种颜色的微妙暗示。\"\r\n\t\t\tid: \"235998CFC8B3A476\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"610D57F08FA28CC9\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"twilightforest:naga\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0B94571E8C4BEF71\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"42C17082157E8E24\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 3256304039117744465L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"52A41CFD68D0D965\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6E2467776F1045F7\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"twilightforest:yeti_trophy\"\r\n\t\t\tx: 5.5d\r\n\t\t\ty: 0.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tid: \"04287692226241F9\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"761D5339B305D59D\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:yeti_alpha_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:yeti_alpha\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7E9D951442B14DC6\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"62D64B87451241B7\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 3168213399534062586L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1A8FD2FF88291CE9\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5BD366D1F6736405\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"twilightforest:giant_pickaxe\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tDamage: 0\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 6.5d\r\n\t\t\ty: 0.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"巨型矿工可以在高地生物群落的云小屋中找到。与典型的BOSS模型不同，只要房子没有被摧毁，巨型矿工就会继续重生。\"\r\n\t\t\tid: \"2AF05F1B13F5F1E1\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"613DA70F34D60AF3\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:giant_miner_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:giant_miner\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"77F46356D75DC01B\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0E1F19538E146CE8\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4248343337893973070L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"685EE492003F62A8\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"67C8FAF1FB2796D6\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"twilightforest:giant_sword\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tDamage: 0\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 4.5d\r\n\t\t\ty: 0.5d\r\n\t\t\tshape: \"diamond\"\r\n\t\t\tsubtitle: \"巨人生活在高地生物群落上方的坚实云层中。它们采取玩家的皮肤外观，因此对每个玩家看起来都不同，尽管原因仍然不明。虽然由于它们的大小，它们看起来移动缓慢，但与大多数生物相比，它们实际上移动相当快。巨人对他们发现的玩家具有攻击性，尽管相对于他们的大小，它们的感官范围相当小。它们很难用近战武器战斗，最好用远程攻击来对付它们。\"\r\n\t\t\tid: \"19FBBD6FF4DA8A08\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"500F2E95AD1A7BD8\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"twilightforest:armored_giant_spawn_egg\"\r\n\t\t\t\t\tentity: \"twilightforest:armored_giant\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7AEC6E5B62AE5681\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"51FB1F08B8E61C1D\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 1375643567800692047L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"122A92A5E69EEFC7\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"462B8F0C5CA75C62\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/pharaoh.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 5.5d\r\n\t\t\ty: 3.0d\r\n\t\t\tid: \"2FE9AFC338329202\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"06F90F6B8CF84024\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"atum:pharaoh\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3C49AFB9AD82D148\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6323FD0CDAD72096\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"57F8F63794A88A0B\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"atum:relic_silver_idol\"\r\n\t\t\tx: 6.5d\r\n\t\t\ty: 3.0d\r\n\t\t\tid: \"5643AA0510639079\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"24B38F232AD16E83\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"atum:bandit_warlord\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3F94A6775F67E4CC\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"667D90FFFF6C138B\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 687554054301909623L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7FE8CD04B9BD02D5\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/sg.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 4.5d\r\n\t\t\ty: 3.0d\r\n\t\t\tid: \"586984CDA7094888\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"22B8188F3A00E07B\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"atum:stoneguard\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5E5E60416BD70305\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7864FB31EF0F03C1\"\r\n\t\t\t\t\ttype: \"random\"\r\n\t\t\t\t\ttable_id: 5351675120932028234L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5B0CE91C0880FA36\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/sw.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -4.5d\r\n\t\t\ty: 3.0d\r\n\t\t\tid: \"108CD35E863201C1\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5CA6A2779A32BE7D\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\tentity: \"atum:stonewarden\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5E18F6F0D5D1C6EE\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 100\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2F6A52066FFDE955\"\r\n\t\t\t\t\ttype: \"random\"\r\n\t\t\t\t\ttable_id: 5351675120932028234L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1EFDA8D762BC73D5\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/wither.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 2.0d\r\n\t\t\ty: -0.5d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"凋灵是一种不死的敌对BOSS模型，可以漂浮并向玩家和生物发射爆炸性头骨，只能由玩家有意建造。它是nether stars的唯一来源，用于制作信标。\"\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"335EECE2A8A1DF81\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3B179A23F583E826\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: {\r\n\t\t\t\t\t\tid: \"inventorypets:pet_wither\"\r\n\t\t\t\t\t\tCount: 1b\r\n\t\t\t\t\t\ttag: {\r\n\t\t\t\t\t\t\tDamage: 0\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t\tentity: \"minecraft:wither\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"6F13610A843146D5\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 1000\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7D24B80BC596F367\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 687554054301909623L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"44F3646C5B90828F\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"632F73F901FFFC55\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\tx: -2.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"诡异蚊子是猩红蚊子的侵略性迷你BOSS版本，如果猩红蚊子吸了覆盖着诡异菌菇的蘑菇的血，它就会出现。\"\r\n\t\t\tsize: 1.1d\r\n\t\t\tid: \"0DA86756ACBD3A5F\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1BF9E2696C0FB5F2\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: {\r\n\t\t\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\t\t\tCount: 1b\r\n\t\t\t\t\t\ttag: {\r\n\t\t\t\t\t\t\tIcon: \"kubejs:textures/item/warpmos.png\"\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t\tentity: \"alexsmobs:warped_mosco\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"7F96AA9151E3F7A9\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 200\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2429201E786571AC\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 1375643567800692047L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4AD267C91B9E1AC5\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 4432288867142743846L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"34C38D7A5B8A7551\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/queebee.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -5.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tsubtitle: \"&l蜂后&r是一个不会自然生成的BOSS。\"\r\n\t\t\tdescription: [\"她拥有巨大的刺，能够造成大量伤害。她还可以让附近的蜜蜂攻击玩家。你可以通过打破生成在平原和花林中的&l&o&6巨大蜂巢&r来召唤蜂后。\"]\r\n\t\t\tid: \"371592CFC60C6C47\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"09D8510BF63826D3\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"forestcraft:beequeen_spawn_egg\"\r\n\t\t\t\t\tentity: \"forestcraft:beequeen\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"43B66B3995C662C3\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1A915AB2736940CA\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"174EA80193E6BABD\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"rats:marbled_cheese_rat_head\"\r\n\t\t\tx: 4.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tid: \"250E6B746624E799\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"28086804E3B12C9A\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"rats:spawn_egg_ratlantean_automaton\"\r\n\t\t\t\t\tentity: \"rats:ratlantean_automaton\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"579FE7E49270B735\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 500\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"11A8D6F87C9AF8CC\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 7842739214414806319L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5074F55581C3C863\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 2000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"rats:dutchrat_wheel\"\r\n\t\t\tx: 5.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tid: \"1570A1AB43C30BEA\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"4C031F97F25F6F4F\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"rats:spawn_egg_dutchrat\"\r\n\t\t\t\t\tentity: \"rats:dutchrat\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0FD3106CDEBE2A4F\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"192061BF2A14C1ED\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0A97C1600E1F3132\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: \"rats:psionic_rat_brain\"\r\n\t\t\tx: 6.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tid: \"66494ABA0B6F4586\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3EC6A957E0E7F171\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"rats:spawn_egg_neo_ratlantean\"\r\n\t\t\t\t\tentity: \"rats:neo_ratlantean\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3FDB337BD2C28FEB\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 400\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"2F2BABCC693B2AFF\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 7643435528041904640L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"07412F0FD13F6BC8\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1500L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"rats:black_death_mask\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tDamage: 0\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 7.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tid: \"143AF037843BFC2B\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"12D2FBCB814F73E3\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"rats:spawn_egg_black_death\"\r\n\t\t\t\t\tentity: \"rats:black_death\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"0D1A6AEB2F737363\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5A293C134B939CD1\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1DACA2A73F079ADB\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/iguki.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -7.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tsubtitle: \"&l鬣蜥王&r是一个不会自然生成的BOSS。\"\r\n\t\t\tdescription: [\"鬣蜥王是一个极具攻击性的BOSS，可以用它的攻击器打破方块。要召唤鬣蜥王，你必须找到一个&l&o&6丛林&r中带有一个蛋的&l&o&6大巢&r并打破它。\"]\r\n\t\t\tid: \"51E4DC25FBC03E44\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3F4BF6732DD2BBE2\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"forestcraft:iguana_king_spawn_egg\"\r\n\t\t\t\t\tentity: \"forestcraft:iguana_king\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"72E8B31B32F7138F\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"384EC8D2E2C79E78\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"60DA61323EAE1384\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/arsen.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -6.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tsubtitle: \"&l古老哨兵&r是一个不会自然生成的BOSS。\"\r\n\t\t\tdescription: [\"他拥有难以解释的力量，可以操纵白天和黑夜，根据不同的时间他会改变自己的特性。可以通过使用&l&o&6春分图腾&r来召唤他。\"]\r\n\t\t\tid: \"12A322CE329BE1F6\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"21D75CBCB7E58836\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"forestcraft:archaic_sentinel_spawn_egg\"\r\n\t\t\t\t\tentity: \"forestcraft:archaic_sentinel\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1F36A5E2BAFAC8FA\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"791E543881E3059E\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"269FC2D2E0EB7E10\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/nethsco.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: -4.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tsubtitle: \"&l地狱灾虫&r是一个不会自然生成的BOSS。\"\r\n\t\t\tdescription: [\"这个生物是凋零的远房亲戚。如果它不在家园维度，就会开始暴怒。可以通过使用&l&6&o恶魔食物&r来召唤它。\"]\r\n\t\t\tid: \"5A5DEE0A4741ACAF\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"1B950FA5F1CF0FC5\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"forestcraft:nether_scourge_spawn_egg\"\r\n\t\t\t\t\tentity: \"forestcraft:nether_scourge\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"73D3A28DC668AC3D\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"785D0A39C30CD2AC\"\r\n\t\t\t\t\ttype: \"loot\"\r\n\t\t\t\t\ttable_id: 6363515282471183984L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"730C692838BBF685\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t\t{\r\n\t\t\ticon: {\r\n\t\t\t\tid: \"ftbquests:custom_icon\"\r\n\t\t\t\tCount: 1b\r\n\t\t\t\ttag: {\r\n\t\t\t\t\tIcon: \"kubejs:textures/item/eaterod.png\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tx: 2.0d\r\n\t\t\ty: 4.0d\r\n\t\t\tshape: \"pentagon\"\r\n\t\t\tsubtitle: \"一种喜欢狩猎的海怪。在战斗中，它会开始在附近盘旋，定期施加盲目和虚弱效果，向你方向突进。被杀后，海蓝宝石会在海中生成。它真的会在深海中生成。\"\r\n\t\t\tsize: 1.2d\r\n\t\t\tid: \"099EE705DED82FBB\"\r\n\t\t\ttasks: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"041FE8550931D472\"\r\n\t\t\t\t\ttype: \"kill\"\r\n\t\t\t\t\ticon: \"forestcraft:eater_of_the_depths_spawn_egg\"\r\n\t\t\t\t\tentity: \"forestcraft:eater_of_the_depths\"\r\n\t\t\t\t\tvalue: 1L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t\trewards: [\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"5E94B32890DD4717\"\r\n\t\t\t\t\ttype: \"xp\"\r\n\t\t\t\t\txp: 300\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"58E38FAC9AB6E574\"\r\n\t\t\t\t\ttype: \"random\"\r\n\t\t\t\t\ttable_id: 687554054301909623L\r\n\t\t\t\t}\r\n\t\t\t\t{\r\n\t\t\t\t\tid: \"3EC1EF505A984A84\"\r\n\t\t\t\t\ttype: \"ftbmoney:money\"\r\n\t\t\t\t\tftb_money: 1000L\r\n\t\t\t\t}\r\n\t\t\t]\r\n\t\t}\r\n\t]\r\n}\r\n";
        var result = StringNbt.Parse(input,true);
        Console.WriteLine(result.PrettyPrinted());
    }
}


//public class WarpScanner
//{
//    private string input;
//    private int position;
//    private char Current => input[position];

//    public WarpScanner(string input)
//    {
//        this.input = input;
//        position = 0;
//    }

//    public CompoundTag Scan()
//    {
//        SkipWhitespace();
//        if (input[position] == '{')
//        {
//            return ScanObject(null);
//        }

//        throw new SyntaxErrorException($"Expected '{{', got '{Current}'.");
//    }

//    private CompoundTag ScanObject(string? name)
//    {
//        SkipWhitespace(); //跳过开头的空白
//        CompoundTag obj = new(name); //创建新的Tag

//        //Dictionary<string, Tag?> properties = new ();

//        MoveNext(); // Skip the opening curly brace '{'
//        SkipWhitespace();
//        if (Current == '}') // For the case of "{}", return empty compound tag.
//            return obj;

//        while (position < input.Length && input[position] != '}')
//        {
//            SkipWhitespace();

//            string propertyName = ScanPropertyName();
//            SkipWhitespace();
//            ScanColon();
//            SkipWhitespace();
//            Tag propertyValue = ScanPropertyValue(propertyName);

//            obj.Add(propertyValue);

//            SkipWhitespace();

//            //if (input[position] == ',')
//            //{
//            //    MoveNext(); // Skip the comma ','
//            //}
//            if (input[position] != '\r' || input[position] != '\n' || input[position] != '\t')
//            {
//                SkipWhitespace();
//            }
//            else if (input[position] != '}')
//            {
//                throw new SyntaxErrorException($"Expected warp or  '}}', got '{Current}'.");
//            }
//        }
//        SkipWhitespace();
//        MoveNext(); // Skip the closing curly brace '}'

//        //foreach (var property in properties)
//        //{
//        //    ((IDictionary<string, object>)obj)[property.Key] = property.Value;
//        //}

//        return obj;
//    }

//    private string ScanPropertyName()
//    {
//        string propertyName = string.Empty;

//        //if (input[position] == '\"')
//        //{
//        //MoveNext(); // Skip the opening double quote '\"'

//        while (position < input.Length && input[position] != ':')
//        {
//            propertyName += input[position];
//            MoveNext();
//        }

//        //MoveNext(); //Skip the closing double quote '\"'
//        //}

//        return propertyName;
//    }

//    private void ScanColon()
//    {
//        if (input[position] != ':')
//        {
//            throw new SyntaxErrorException($"Expected ':', got '{Current}'.");
//        }

//        MoveNext(); // Skip the colon ':'
//    }

//    private Tag ScanPropertyValue(string? name)
//    {
//        SkipWhitespace();
//        if (input[position] == '{')
//        {
//            return ScanObject(name);
//        }
//        else if (input[position] == '[')
//        {
//            return ScanArray(name);
//        }
//        else if (input[position] == '\"')
//        {
//            return ScanString(name);
//        }
//        else
//        {
//            return ScanPrimitiveValue(name);
//        }
//    }

//    private ListTag ScanArray(string? name)
//    {
//        List<Tag> array = new();

//        MoveNext(); // Skip the opening square bracket '['
//        SkipWhitespace();
//        if (input[position] == ']')
//        {
//            return new ListTag(name, TagType.End);
//        }
//        while (position < input.Length && input[position] != ']')
//        {
//            Tag element;
//            if (position < input.Length && input[position] == '{')
//            {
//                element = ScanObject(name);
//            }
//            else
//            {
//                SkipWhitespace();

//                element = ScanPropertyValue(name);

//                SkipWhitespace();
//            }
//            array.Add(element);

//            if (input[position] != '\r' || input[position] != '\n' || input[position] != '\t')
//            {
//                SkipWhitespace();
//            }
//            else if (input[position] != ']')
//            {
//                throw new SyntaxErrorException($"Expected warp or ']', got '{Current}'.");
//            }
//        }

//        MoveNext(); // Skip the closing square bracket ']'

//        return new ListTag(name, array[0].Type, array);
//    }

//    private StringTag ScanString(string? name)
//    {
//        string str = string.Empty;

//        MoveNext(); // Skip the opening double quote '\"'

//        while (position < input.Length && input[position] != '\"')
//        {
//            str += input[position];
//            MoveNext();
//        }

//        MoveNext(); // Skip the closing double quote '\"'

//        return new StringTag(name, str);
//    }

//    private dynamic ScanPrimitiveValue(string? name)
//    {
//        string value = string.Empty;

//        while (
//            position < input.Length
//            && !char.IsWhiteSpace(input[position])
//            && input[position] != ','
//            && input[position] != '}'
//        )
            
//        {
//            value += input[position];
//            MoveNext();
//        }

//        if (bool.TryParse(value, out bool boolValue))
//        {
//            return new ByteTag(name, boolValue);
//        }
//        else if ("lL".Contains(value.Last()))
//        {
//            if (long.TryParse(value.Substring(0, value.Length - 1), out long longValue))
//                return new LongTag(name, longValue);
//        }
//        else if ("dD".Contains(value.Last()))
//        {
//            if (double.TryParse(value.Substring(0, value.Length - 1), out double floatValue))
//                return new DoubleTag(name, floatValue);
//        }
//        else if ("bB".Contains(value.Last()))
//        {
//            if (sbyte.TryParse(value.Substring(0, value.Length - 1), out sbyte sbyteValue))
//                return new ShortTag(name, sbyteValue);
//        }
//        else if (int.TryParse(value, out int intValue))
//        {
//            return new IntTag(name, intValue);
//        }
//        //else if (value.Contains("ABCDEF"))
//        //{
//        //    return value;
//        //}
//        return new StringTag(name, value);
//    }

//    private void SkipSpace()
//    {
//        while (position < input.Length && (input[position]) == ' ')
//        {
//            MoveNext();
//        }
//    }

//    [DebuggerHidden]
//    private void SkipWrap()
//    {
//        while (
//            position < input.Length
//            && ((input[position]) == '\n' || (input[position]) == '\r' || (input[position]) == '\t')
//        )
//        {
//            MoveNext();
//        }
//    }

//    [DebuggerHidden]
//    private void SkipWhitespace()
//    {
//        while (position < input.Length && char.IsWhiteSpace(input[position]))
//        {
//            MoveNext();
//        }
//    }

//    [DebuggerHidden]
//    private void MoveNext()
//    {
//        Console.Write(input[position]);
//        position++;
//    }
//}

//public class WarpScanner
//{
//    private string input;
//    private int position;
//    private char Current => input[position];

//    public WarpScanner(string input)
//    {
//        this.input = input;
//        this.position = 0;
//    }

//    public dynamic Scan()
//    {
//        SkipWhitespace();

//        if (input[position] == '{')
//        {
//            return ScanObject();
//        }

//        throw new SyntaxErrorException($"Expected '{{', got '{Current}'.");
//    }

//    private dynamic ScanObject()
//    {
//        SkipWhitespace();
//        dynamic obj = new System.Dynamic.ExpandoObject();
//        Dictionary<string, dynamic> properties = new Dictionary<string, dynamic>();

//        MoveNext(); // Skip the opening curly brace '{'

//        while (position < input.Length && input[position] != '}')
//        {
//            SkipWhitespace();

//            string propertyName = ScanPropertyName();
//            SkipWhitespace();
//            ScanColon();
//            SkipWhitespace();
//            dynamic propertyValue = ScanPropertyValue();

//            properties[propertyName] = propertyValue;

//            SkipWhitespace();

//            //if (input[position] == ',')
//            //{
//            //    MoveNext(); // Skip the comma ','
//            //}
//            if (input[position] != '\r' || input[position] != '\n' || input[position] != '\t')
//            {
//                SkipWhitespace();
//            }
//            else if (input[position] != '}')
//            {
//                throw new SyntaxErrorException($"Expected warp or  '}}', got '{Current}'.");
//            }
//        }

//        MoveNext(); // Skip the closing curly brace '}'

//        foreach (var property in properties)
//        {
//            ((IDictionary<string, object>)obj)[property.Key] = property.Value;
//        }

//        return obj;
//    }

//    private string ScanPropertyName()
//    {
//        string propertyName = string.Empty;

//        //if (input[position] == '\"')
//        //{
//        //MoveNext(); // Skip the opening double quote '\"'

//        while (position < input.Length && input[position] != ':')
//        {
//            propertyName += input[position];
//            MoveNext();
//        }

//        //MoveNext(); //Skip the closing double quote '\"'
//        //}

//        return propertyName;
//    }

//    private void ScanColon()
//    {
//        if (input[position] != ':')
//        {
//            throw new SyntaxErrorException($"Expected ':', got '{Current}'.");
//        }

//        MoveNext(); // Skip the colon ':'
//    }

//    private dynamic ScanPropertyValue()
//    {
//        if (input[position] == '{')
//        {
//            return ScanObject();
//        }
//        else if (input[position] == '[')
//        {
//            return ScanArray();
//        }
//        else if (input[position] == '\"')
//        {
//            return ScanString();
//        }
//        else
//        {
//            return ScanPrimitiveValue();
//        }
//    }

//    private dynamic ScanArray()
//    {
//        List<dynamic> array = new List<dynamic>();

//        MoveNext(); // Skip the opening square bracket '['
//        SkipWhitespace();
//        if (input[position] == ']')
//        {
//            return null;
//        }
//        while (position < input.Length && input[position] != ']')
//        {
//            dynamic element;
//            if (position < input.Length && input[position] == '{')
//            {
//                element = ScanObject();
//            }
//            else
//            {
//                SkipWhitespace();

//                element = ScanPropertyValue();

//                SkipWhitespace();
//            }
//            array.Add(element);

//            if (input[position] != '\r' || input[position] != '\n' || input[position] != '\t')
//            {
//                SkipWhitespace();
//            }
//            else if (input[position] != ']')
//            {
//                throw new SyntaxErrorException($"Expected warp or ']', got '{Current}'.");
//            }
//        }

//        MoveNext(); // Skip the closing square bracket ']'

//        return array;
//    }

//    private string ScanString()
//    {
//        string str = string.Empty;

//        MoveNext(); // Skip the opening double quote '\"'

//        while (position < input.Length && input[position] != '\"')
//        {
//            str += input[position];
//            MoveNext();
//        }

//        MoveNext(); // Skip the closing double quote '\"'

//        return str;
//    }

//    private dynamic ScanPrimitiveValue()
//    {
//        string value = string.Empty;

//        while (
//            position < input.Length
//            && !char.IsWhiteSpace(input[position])
//            && input[position] != ','
//            && input[position] != '}'
//        )
//        {
//            value += input[position];
//            MoveNext();
//        }

//        if (bool.TryParse(value, out bool boolValue))
//        {
//            return boolValue;
//        }
//        else if ("lL".Contains(value.Last()))
//        {
//            if (ulong.TryParse(value.Substring(0, value.Length - 1), out ulong ulongValue))
//                return ulongValue;
//        }
//        else if ("dD".Contains(value.Last()))
//        {
//            if (double.TryParse(value.Substring(0, value.Length - 1), out double floatValue))
//                return floatValue;
//        }
//        else if ("bB".Contains(value.Last()))
//        {
//            if (sbyte.TryParse(value.Substring(0, value.Length - 1), out sbyte sbyteValue))
//                return sbyteValue;
//        }
//        else if (int.TryParse(value, out int intValue))
//        {
//            return intValue;
//        }
//        else if (value.Contains("ABCDEF"))
//        {
//            return value;
//        }
//        return value;
//    }

//    private void SkipSpace()
//    {
//        while (position < input.Length && (input[position]) == ' ')
//        {
//            MoveNext();
//        }
//    }

//    [DebuggerHidden]
//    private void SkipWrap()
//    {
//        while (
//            position < input.Length
//            && ((input[position]) == '\n' || (input[position]) == '\r' || (input[position]) == '\t')
//        )
//        {
//            MoveNext();
//        }
//    }

//    [DebuggerHidden]
//    private void SkipWhitespace()
//    {
//        while (position < input.Length && char.IsWhiteSpace(input[position]))
//        {
//            MoveNext();
//        }
//    }

//    [DebuggerHidden]
//    private void MoveNext()
//    {
//        //Console.Write(input[position]);
//        position++;
//    }
//}
