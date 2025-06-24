// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutCorehrV2ProcessWithdrawByProcessIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤回流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤回流程 请求体
/// <para>接口ID：7431231062508126209</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_withdraw%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCorehrV2ProcessWithdrawByProcessIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "ou_91791271921729102012",
    "reason": "原因自定义字符串",
    "system_user": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PutCorehrV2ProcessWithdrawByProcessIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}