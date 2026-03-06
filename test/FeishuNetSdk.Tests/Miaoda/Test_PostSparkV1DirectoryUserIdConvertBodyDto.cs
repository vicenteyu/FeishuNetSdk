// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="Test_PostSparkV1DirectoryUserIdConvertBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 妙搭和飞书用户 ID 转换 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 妙搭和飞书用户 ID 转换 请求体
/// <para>接口ID：7613807342706871517</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/directory-user/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fdirectory-user%2fid_convert</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1DirectoryUserIdConvertBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id_convert_type": 10,
    "ids": [
        "123456789837364"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PostSparkV1DirectoryUserIdConvertBodyDto>(json);
        Assert.IsNotNull(result);
    }
}