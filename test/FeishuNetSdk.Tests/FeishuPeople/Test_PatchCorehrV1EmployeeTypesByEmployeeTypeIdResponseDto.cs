// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV1EmployeeTypesByEmployeeTypeIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新人员类型 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新人员类型 响应体
/// <para>接口ID：7021731966426415107</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployee_type%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1EmployeeTypesByEmployeeTypeIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employee_type": {
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PatchCorehrV1EmployeeTypesByEmployeeTypeIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}