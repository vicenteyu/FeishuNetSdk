// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建字段编组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 创建字段编组 请求体
/// <para>接口ID：7600708368865856725</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field_group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field_group%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "field_groups": [
        {
            "id": "fldPTb0U2y",
            "name": "用户信息组",
            "children": [
                {
                    "type": "field",
                    "id": "fldPTb0U2y"
                }
            ],
            "description": "用于组织用户信息相关的字段"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}