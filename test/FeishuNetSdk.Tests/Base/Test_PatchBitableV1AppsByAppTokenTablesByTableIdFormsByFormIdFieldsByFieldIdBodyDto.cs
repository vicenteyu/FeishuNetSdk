// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-02-06
// ************************************************************************
// <copyright file="Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新表单问题 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新表单问题 请求体
/// <para>接口ID：7112628058154893314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "pre_field_id": "fldjX7dUj5",
    "title": "任务名称",
    "description": "请概述该任务",
    "required": true,
    "visible": true,
    "rich_description": [
        {
            "segment_type": "text",
            "text": "这是一个开放性问题",
            "link": "https://open.larkoffice.com/"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}