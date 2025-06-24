// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询角色成员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询角色成员信息 响应体
/// <para>接口ID：7417675812785455107</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/permission/application-role-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-role-member%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "role_member": {
            "role_api_id": "role_api_id",
            "role_api_name": "adminRole",
            "users": [
                "1802412778084426"
            ],
            "departments": [
                "1802412778084426"
            ],
            "user_filter": {
                "conditions": [
                    {
                        "index": "1",
                        "left": {
                            "type": "metadataVariable",
                            "settings": "{\"fieldPath\":[{\"fieldApiName\": \"_id\",\"objectApiName\": \"_user\"}]}",
                            "display_names": [
                                "用户.ID"
                            ]
                        },
                        "right": {
                            "type": "metadataVariable",
                            "settings": "{\"fieldPath\":[{\"fieldApiName\": \"_id\",\"objectApiName\": \"_user\"}]}",
                            "display_names": [
                                "用户.ID"
                            ]
                        },
                        "operator": "equal"
                    }
                ],
                "logic_expression": "1 and 2"
            },
            "user_display_infos": [
                {
                    "id": "1802412778084426",
                    "name": "张三"
                }
            ],
            "department_display_infos": [
                {
                    "id": "1802412778084426",
                    "name": "张三"
                }
            ],
            "type": "custom",
            "updated_by": "1802412778084426",
            "updated_at": 1702546522477
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}