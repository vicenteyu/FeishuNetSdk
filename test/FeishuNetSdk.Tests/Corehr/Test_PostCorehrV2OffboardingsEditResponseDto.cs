// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2OffboardingsEditResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 编辑离职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 编辑离职信息 响应体
/// <para>接口ID：7386577676713328643</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fedit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2OffboardingsEditResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data": [
            {
                "field_name": "name",
                "value": "Sandy"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2OffboardingsEditResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}