// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="Test_PostSparkV1IconResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传妙搭应用图标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 上传妙搭应用图标 响应体
/// <para>接口ID：7642228089434918069</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/icon</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2ficon</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1IconResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "icon_url": "https://spark-cdn.example.com/tenant/10001/app-icons/20240520/abcdef123456.png"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1IconResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}