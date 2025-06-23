namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 创建 / 更新外部算薪数据 响应体
/// <para>接口ID：7411366924142460930</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/save</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fsave</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1DatasourceRecordsSaveResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "affect_counts": "120"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.PostPayrollV1DatasourceRecordsSaveResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}