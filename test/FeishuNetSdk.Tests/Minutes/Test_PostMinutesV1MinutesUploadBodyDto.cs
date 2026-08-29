// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 云空间文件生成妙记 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 云空间文件生成妙记 请求体
/// <para>接口ID：7673720420097412036</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesUploadBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "file_token": "doccnfYZzTlvXqZIGTdAHKabcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Minutes.PostMinutesV1MinutesUploadBodyDto>(json);
        Assert.IsNotNull(result);
    }
}