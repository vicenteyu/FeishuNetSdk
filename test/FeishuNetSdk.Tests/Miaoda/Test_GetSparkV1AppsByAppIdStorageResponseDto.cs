// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdStorageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 下载文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 下载文件 响应体
/// <para>接口ID：7624421835341679553</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/download</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fdownload</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdStorageResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "content_type": "image/jpeg"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdStorageResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}