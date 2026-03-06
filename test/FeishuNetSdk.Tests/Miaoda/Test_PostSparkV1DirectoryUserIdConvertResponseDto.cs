// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="Test_PostSparkV1DirectoryUserIdConvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 妙搭和飞书用户 ID 转换 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 妙搭和飞书用户 ID 转换 响应体
/// <para>接口ID：7613807342706871517</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/directory-user/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fdirectory-user%2fid_convert</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1DirectoryUserIdConvertResponseDto : TestBase
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
                "source_id": "123445678933432",
                "target_id": "ou_1234cdjhjfedgfhgdhy3884"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1DirectoryUserIdConvertResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}