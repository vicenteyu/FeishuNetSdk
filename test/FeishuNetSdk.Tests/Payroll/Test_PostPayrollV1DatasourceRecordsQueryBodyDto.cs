namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 批量查询外部算薪数据记录 请求体
/// <para>接口ID：7411366924142477314</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1DatasourceRecordsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "source_code": "yache19_8680__c",
    "selected_fields": [
        "yache41_8680__c"
    ],
    "field_filters": [
        {
            "field_code": "employment_id",
            "field_values": [
                "6993242233201853965",
                "7163264720525592101"
            ]
        },
        {
            "field_code": "payroll_period",
            "field_values": [
                "2024-10"
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Payroll.PostPayrollV1DatasourceRecordsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}