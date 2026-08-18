// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="Test_PostVcV1BotsJoinResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 加入会议 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 加入会议 响应体
/// <para>接口ID：7672664994767015159</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/join</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fjoin</para>
/// </summary>
[TestClass]
public class Test_PostVcV1BotsJoinResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "msg": "success",
  "data": {
    "meeting": {
      "id": "7628568141510692381",
      "meeting_no": "MTG202405201030001",
      "start_time": "2024-05-20 10:30:00",
      "topic": "产品规划评审会"
    },
    "join_user": {
      "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
      "user_type": 1
    }
  }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1BotsJoinResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}