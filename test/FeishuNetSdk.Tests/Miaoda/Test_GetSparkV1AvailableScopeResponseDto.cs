// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_GetSparkV1AvailableScopeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙搭产品使用权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取妙搭产品使用权限 响应体
/// <para>接口ID：7679858182358027206</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-available_scope/open_api_get_miaoda_available_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-available_scope%2fopen_api_get_miaoda_available_scope</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AvailableScopeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "available_scope": "ALLOW_PART",
        "department_ids": [
            "dpt_12345"
        ],
        "user_ids": [
            "usr_67890"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AvailableScopeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}