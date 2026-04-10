// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="Test_PostDriveV2FilesByFileTokenCommentsReactionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加/取消表情回应 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 添加/取消表情回应 请求体
/// <para>接口ID：7626674272942312397</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uIzNzUjLyczM14iM3MTN/drive-v2/comment_reaction/update_reaction</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2fcomment_reaction%2fupdate_reaction</para>
/// </summary>
[TestClass]
public class Test_PostDriveV2FilesByFileTokenCommentsReactionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "action": "add",
    "reply_id": "1234567890",
    "reaction_type": "ANGRY"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV2FilesByFileTokenCommentsReactionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}