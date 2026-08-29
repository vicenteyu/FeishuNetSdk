// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 云空间文件生成妙记 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 云空间文件生成妙记 响应体
/// <para>接口ID：7673720420097412036</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "minute_url": "https://bytedance.feishu.cn/minutes/obcnq3b9jl72l83w4f14xxxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.PostMinutesV1MinutesUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}