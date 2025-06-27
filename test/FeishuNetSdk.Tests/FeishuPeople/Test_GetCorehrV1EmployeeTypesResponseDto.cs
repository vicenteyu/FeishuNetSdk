// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1EmployeeTypesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询人员类型 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询人员类型 响应体
/// <para>接口ID：7017694651622080516</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployee_type%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1EmployeeTypesResponseDto : TestBase
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
                "id": "6919732473504990727",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "default_employee_type": true,
                "active": true,
                "code": "1245",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1EmployeeTypesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}