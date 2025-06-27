// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetLingoV1ReposResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取词库列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 获取词库列表 响应体
/// <para>接口ID：7249689905697177628</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/repo/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2frepo%2flist</para>
/// </summary>
[TestClass]
public class Test_GetLingoV1ReposResponseDto : TestBase
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
                "id": "71527909***274113",
                "name": "全员词库"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.GetLingoV1ReposResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}