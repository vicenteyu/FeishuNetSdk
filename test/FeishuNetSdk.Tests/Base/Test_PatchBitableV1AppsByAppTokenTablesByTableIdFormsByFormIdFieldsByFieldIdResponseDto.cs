// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新表单问题 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新表单问题 响应体
/// <para>接口ID：7112628058154893314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "field": {
            "pre_field_id": "fldjX7dUj5",
            "title": "任务名称",
            "description": "请概述该任务",
            "required": true,
            "visible": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}