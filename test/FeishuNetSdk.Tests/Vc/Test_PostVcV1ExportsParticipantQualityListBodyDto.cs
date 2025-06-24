// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostVcV1ExportsParticipantQualityListBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导出参会人会议质量数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 导出参会人会议质量数据 请求体
/// <para>接口ID：7124195547444494364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/participant_quality_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fparticipant_quality_list</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ExportsParticipantQualityListBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "meeting_start_time": "1655276858",
    "meeting_end_time": "1655276858",
    "meeting_no": "123456789",
    "join_time": "1655276858",
    "user_id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
    "room_id": "omm_eada1d61a550955240c28757e7dec3af"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1ExportsParticipantQualityListBodyDto>(json);
        Assert.IsNotNull(result);
    }
}