using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PromptGenerator : MonoBehaviour
{
    public List<string> prompts = new List<string>()
{
    "Screw", // 螺丝钉
    "Scissors", // 剪刀
    "Key", // 钥匙
    "Faucet", // 水龙头
    "Television", // 电视
    "Speaker", // 音响
    "Washing Machine", // 洗衣机
    "Shoelace", // 鞋带
    "Socks", // 袜子
    "Lipstick", // 口红
    "Brush", // 刷子
    "Hat", // 帽子
    "Earrings", // 耳环
    "Glasses", // 眼镜
    "Pen", // 钢笔
    "Computer", // 电脑
    "Popcorn", // 看戏
    "Gaming Console", // 游戏机
    "Candle", // 蜡烛
    "Violin", // 小提琴
    "Watch", // 手表
    "Cardboard Box", // 纸箱
    "Electric Scooter", // 电瓶车
    "Radio", // 收音机
    "Toilet", // 马桶
    "Wall", // 墙壁
    "Carpet", // 地毯
    "Matches", // 火柴
    "Electric Fan", // 电风扇
    "Sofa", // 沙发
    "Book", // 书本
    "High Heels", // 高跟鞋
    "Chair", // 椅子
    "Globe", // 地球仪
    "Coffee Cup", // 咖啡杯
    "Cellphone", // 手机
    "Stamp", // 邮票
    "Keychain", // 钥匙链
    "Bookshelf", // 书架
    "Remote Control", // 电视遥控器
    "Pencil", // 铅笔
    "Mop", // 拖把
    "Trash Can", // 垃圾桶
    "Light Bulb", // 灯泡
    "Hair", // 头发
    "Feather", // 羽毛
    "Hair Dryer", // 电吹风
    "Keyboard", // 键盘
    "Piano", //钢琴
    "Duck", // 鸭子
    "Desk Lamp", // 台灯
    "Alarm Clock", // 闹钟
    "Spider Web", // 蜘蛛网
    "Iron", // 电熨斗
    "Speaker", // 音箱
    "Bell", // 铃铛
    "Coin", // 钱币
    "Candlestick", // 蜡烛台
    "Laptop", // 笔记本电脑
    "Tape Measure", // 卷尺
    "Bee", // 蜜蜂
    "Desk Calendar", // 台历
    "Skateboard", // 滑板
    "Rice Cooker", // 电饭煲
    "Camera", // 相机
    "Umbrella", // 雨伞
    "Street Light", // 路灯
    "Lock", // 锁
    "Wine Glass", // 酒杯
    "Chess Piece", // 棋子
    "Nail Clippers", // 指甲钳
    "Hook", // 钩子
    "Newspaper", // 报纸
    "Playing Cards", // 牌
};
    private TextMeshProUGUI promptText;
    void Start()
    {
        promptText = GameObject.Find("Prompt Text").GetComponent<TextMeshProUGUI>();
        promptText.text = prompts[Random.Range(0, prompts.Count)];
    }
    
    void Update()
    {
        
    }

    public void GeneratePrompt()
    {
        string currentPrompt = promptText.text;
        for (int i = 0; i < 1;)
        {
            string newPrompt = prompts[Random.Range(0, prompts.Count)];
            if (newPrompt != currentPrompt)
            {
                promptText.text = newPrompt;
                i++;
            }
        }
    }
}
