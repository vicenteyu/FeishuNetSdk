namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建外部背调 请求体
/// <para>接口ID：6992822583076372483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalBackgroundChecksBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_id": "7003247299220982060",
    "external_application_id": "7003247299220982060",
    "date": 1626602069392,
    "name": "张三的背调",
    "result": "已通过",
    "attachment_id_list": [
        "7249929009008494908"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExternalBackgroundChecksBodyDto>(json);
        Assert.IsNotNull(result);
    }
}