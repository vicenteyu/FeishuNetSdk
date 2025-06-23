namespace FeishuNetSdk.Tests.Contact.Spec;

/// <summary>
/// 测试 批量新增部门 响应体
/// <para>接口ID：6907569524101021697</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-departments</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDOwUjLzgDM14yM4ATN</para>
/// </summary>
[TestClass]
public class Test_PostContactV2DepartmentBatchAddResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task_id": "123456784b68a7c89abcdef092dc09ea"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.Spec.PostContactV2DepartmentBatchAddResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}