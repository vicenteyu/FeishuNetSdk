namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建人才外部信息 响应体
/// <para>接口ID：7045099225022185474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-5</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent-external_info%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsByTalentIdExternalInfoResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "external_info": {
            "talent_id": "7043758982146345222",
            "external_create_time": "1608467675393"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentsByTalentIdExternalInfoResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}