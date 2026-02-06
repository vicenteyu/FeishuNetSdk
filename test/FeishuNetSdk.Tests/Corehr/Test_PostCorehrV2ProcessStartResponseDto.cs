// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-02-06
//
// Last Modified By : yxr
// Last Modified On : 2026-02-06
// ************************************************************************
// <copyright file="Test_PostCorehrV2ProcessStartResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发起流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 发起流程 响应体
/// <para>接口ID：7451908159096766468</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_start%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProcessStartResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "process_id": "7437118147624175148"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ProcessStartResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}