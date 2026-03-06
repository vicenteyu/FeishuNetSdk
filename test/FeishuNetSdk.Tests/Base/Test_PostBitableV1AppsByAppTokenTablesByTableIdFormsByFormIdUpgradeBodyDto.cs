// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 升级表单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 升级表单 请求体
/// <para>接口ID：7600708368865873109</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form/upgrade</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fupgrade</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "form_name": "文档问题反馈",
    "display_mode": "one_question_per_page"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}