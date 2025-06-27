// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2OffboardingsEditBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 编辑离职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 编辑离职信息 请求体
/// <para>接口ID：7386577676713328643</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fedit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2OffboardingsEditBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "offboarding_id": "7095671727698478604",
    "operator_id": "6982509313466189341",
    "update_data": [
        {
            "field_name": "name",
            "value": "Sandy"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2OffboardingsEditBodyDto>(json);
        Assert.IsNotNull(result);
    }
}