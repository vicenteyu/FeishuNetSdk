// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostVcV1NotesUnsubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 取消订阅纪要变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 取消订阅纪要变更事件 请求体
/// <para>接口ID：7646314141168307411</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/note/unsubscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fnote%2funsubscription</para>
/// </summary>
[TestClass]
public class Test_PostVcV1NotesUnsubscriptionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_type": "vc.note.generated_v1"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1NotesUnsubscriptionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}