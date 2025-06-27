// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新表单元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新表单元数据 响应体
/// <para>接口ID：7119425455108669468</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "form": {
            "name": "表单",
            "description": "表单描述",
            "shared": true,
            "shared_url": "https://example.feishu.cn/share/base/shrcnCy1KAlpahNotmhRn1abcde",
            "shared_limit": "tenant_editable",
            "submit_limit_once": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}