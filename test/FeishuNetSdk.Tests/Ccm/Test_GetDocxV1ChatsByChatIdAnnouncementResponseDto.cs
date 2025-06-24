// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDocxV1ChatsByChatIdAnnouncementResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取群公告基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取群公告基本信息 响应体
/// <para>接口ID：7450053428095615004</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDocxV1ChatsByChatIdAnnouncementResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "revision_id": 1,
        "create_time": 1609296809,
        "update_time": 1609296809,
        "owner_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
        "owner_id_type": "user_id",
        "modifier_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
        "modifier_id_type": "user_id",
        "announcement_type": "docx",
        "create_time_v2": "1609296809",
        "update_time_v2": "1609296809"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDocxV1ChatsByChatIdAnnouncementResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}