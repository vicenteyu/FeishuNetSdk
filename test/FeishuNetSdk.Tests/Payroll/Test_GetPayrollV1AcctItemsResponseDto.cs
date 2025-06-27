// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetPayrollV1AcctItemsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询算薪项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 批量查询算薪项 响应体
/// <para>接口ID：7387360801748402177</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/acct_item/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2facct_item%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1AcctItemsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "7169773973790425132",
                "i18n_names": [
                    {
                        "locale": "zh_cn",
                        "value": "名称"
                    }
                ],
                "category_id": "7169773973790425132",
                "data_type": 1,
                "decimal_places": 2,
                "active_status": 1
            }
        ],
        "page_token": "7169773973790425132",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1AcctItemsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}