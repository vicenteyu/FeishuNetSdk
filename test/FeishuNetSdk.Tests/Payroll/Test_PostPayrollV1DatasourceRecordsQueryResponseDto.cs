// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPayrollV1DatasourceRecordsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询外部算薪数据记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 批量查询外部算薪数据记录 响应体
/// <para>接口ID：7411366924142477314</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource_record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1DatasourceRecordsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "7413047003142619148",
        "has_more": true,
        "records": [
            {
                "active_status": 1,
                "field_values": [
                    {
                        "field_code": "yache41_8680__c",
                        "value": "2024-12-01",
                        "field_type": 1
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.PostPayrollV1DatasourceRecordsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}