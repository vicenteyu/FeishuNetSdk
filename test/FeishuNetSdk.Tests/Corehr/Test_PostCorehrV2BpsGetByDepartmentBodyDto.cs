namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询部门 HRBP 请求体
/// <para>接口ID：7261860942295547906</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/get_by_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2fget_by_department</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BpsGetByDepartmentBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_id": "6893014062142064111"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BpsGetByDepartmentBodyDto>(json);
        Assert.IsNotNull(result);
    }
}