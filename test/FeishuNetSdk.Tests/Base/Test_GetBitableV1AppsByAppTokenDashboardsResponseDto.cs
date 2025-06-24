// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenDashboardsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出仪表盘 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出仪表盘 响应体
/// <para>接口ID：7127206859065638914</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenDashboardsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "dashboards": [
            {
                "block_id": "blknkqrP3RqUkcAW",
                "name": "仪表盘1"
            }
        ],
        "page_token": "blknkqrP3RqUkcAW",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenDashboardsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}