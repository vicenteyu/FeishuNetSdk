namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 导出参会人会议质量数据 响应体
/// <para>接口ID：7124195547444494364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/participant_quality_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fparticipant_quality_list</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ExportsParticipantQualityListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task_id": "7111325589855797267"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1ExportsParticipantQualityListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}