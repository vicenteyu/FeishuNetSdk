// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-17
// ************************************************************************
// <copyright file="Test_GetVcV1BotsUserActiveMeetingResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取用户活跃会议列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取用户活跃会议列表 响应体
/// <para>接口ID：7657481714696604903</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/user_active_meeting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fuser_active_meeting</para>
/// </summary>
[TestClass]
public class Test_GetVcV1BotsUserActiveMeetingResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "meetings": [
            {
                "meeting_no": "987654321",
                "meeting_id": "mt_123e4567-e89b-12d3-a456-426614174000",
                "meeting_title": "Q3季度产品迭代评审会"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1BotsUserActiveMeetingResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}