// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="PostDriveV2FilesByFileTokenCommentsReactionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加/取消表情回应 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加/取消表情回应 请求体
/// <para>使用该接口可对云文档中的某条评论进行emoji表情回应或取消emoji表情回应。适用于用户需要对云文档评论进行emoji表情互动的场景。</para>
/// <para>接口ID：7626674272942312397</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uIzNzUjLyczM14iM3MTN/drive-v2/comment_reaction/update_reaction</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2fcomment_reaction%2fupdate_reaction</para>
/// </summary>
public record PostDriveV2FilesByFileTokenCommentsReactionBodyDto
{
    /// <summary>
    /// <para>操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：add</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>add：添加表情回复</item>
    /// <item>delete：删除添加的reaction</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; } = string.Empty;

    /// <summary>
    /// <para>回复 ID</para>
    /// <para>可通过调用 添加回复、获取回复信息 接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234567890</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("reply_id")]
    public string ReplyId { get; set; } = string.Empty;

    /// <summary>
    /// <para>reaction 类型</para>
    /// <para>可选值：ANGRY, APPLAUSE, ATTENTION, AWESOME, BEAR, BEER, BETRAYED, BIGKISS, BLACKFACE, BLUBBER, BLUSH, BOMB, CAKE, CHUCKLE, CLAP, CLEAVER, COMFORT, CRAZY, CRY, CUCUMBER, DETERGENT, DIZZY, DONE, DONNOTGO, DROOL, DROWSY, DULL, DULLSTARE, EATING, EMBARRASSED, ENOUGH, ERROR, EYESCLOSED, FACEPALM, FINGERHEART, FISTBUMP, FOLLOWME, FROWN, GIFT, GLANCE, GOODJOB, HAMMER, HAUGHTY, HEADSET, HEART, HEARTBROKEN, HIGHFIVE, HUG, HUSKY, INNOCENTSMILE, JIAYI, JOYFUL, KISS, LAUGH, LIPS, LOL, LOOKDOWN, LOVE, MONEY, MUSCLE, NOSEPICK, OBSESSED, OK, PARTY, PETRIFIED, POOP, PRAISE, PROUD, PUKE, RAINBOWPUKE, ROSE, SALUTE, SCOWL, SHAKE, SHHH, SHOCKED, SHOWOFF, SHY, SICK, SILENT, SKULL, SLAP, SLEEP, SLIGHT, SMART, SMILE, SMIRK, SMOOCH, SMUG, SOB, SPEECHLESS, SPITBLOOD, STRIVE, SWEAT, TEARS, TEASE, TERROR, THANKS, THINKING, THUMBSUP, TOASTED, TONGUE, TRICK, UPPERLEFT, WAIL, WAVE, WELLDONE, WHAT, WHIMPER, WINK, WITTY, WOW, WRONGED, XBLUSH, YAWN, YEAH, FIREWORKS, BULL, CALF, AWESOMEN, 2021, CANDIEDHAWS, REDPACKET, FORTUNE, LUCK, FIRECRACKER, Yes, No, Get, LGTM, Lemon, EatingFood, Hundred, MinusOne, ThumbsDown, Fire, OKR, Drumstick, BubbleTea, Loudspeaker, Pin, Coffee, Alarm, Trophy, Music, Typing, Pepper, CheckMark, CrossMark.</para>
    /// <para>必填：是</para>
    /// <para>示例值：ANGRY</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("reaction_type")]
    public string ReactionType { get; set; } = string.Empty;
}
