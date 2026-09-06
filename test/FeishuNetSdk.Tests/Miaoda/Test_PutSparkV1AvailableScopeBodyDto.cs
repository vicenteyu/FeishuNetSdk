// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_PutSparkV1AvailableScopeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改妙搭产品使用权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 修改妙搭产品使用权限 请求体
/// <para>接口ID：7679858182358043590</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-available_scope/open_api_update_miaoda_available_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-available_scope%2fopen_api_update_miaoda_available_scope</para>
/// </summary>
[TestClass]
public class Test_PutSparkV1AvailableScopeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "available_scope": "ALLOW_PART",
    "department_ids": [
        "dpt_12345"
    ],
    "user_ids": [
        "usr_67890"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PutSparkV1AvailableScopeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}