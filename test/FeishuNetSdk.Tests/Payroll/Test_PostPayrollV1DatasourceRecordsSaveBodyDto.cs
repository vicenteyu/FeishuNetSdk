namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 创建 / 更新外部算薪数据 请求体
/// <para>接口ID：7411366924142460930</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/save</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fsave</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1DatasourceRecordsSaveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "source_code": "yache19_8680__c",
    "records": [
        {
            "active_status": 1, // 启停状态
            "field_values": [
                {
                    "field_code": "employment_id", // 必传字段，员工ID
                    "value": "6993242233201853965" // 员工ID获取方式见文档
                },
                {
                    "field_code": "payroll_period", // 必传字段，算薪期间
                    "value": "2024-10" // 算薪期间，精确到月
                },
                {
                    "field_code": "yache41_8680__c", // 自定义字段1
                    "value": "2024-10-01"
                },
                {
                    "field_code": "yache11_8680__c", // 自定义字段2
                    "value": "我是一段文本"
                },
                {
                    "field_code": "yache22_8680__c", // 自定义字段3
                    "value": "123"
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Payroll.PostPayrollV1DatasourceRecordsSaveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}