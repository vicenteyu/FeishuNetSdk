// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetReportV1RulesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Report;

/// <summary>
/// 测试 查询规则 响应体
/// <para>接口ID：6969187588792385564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/rule/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2frule%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetReportV1RulesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "rules": [
            {
                "rule_id": "6894788526240432147",
                "name": "工作月报",
                "icon_name": "日报",
                "created_at": 1622427266,
                "creator_user_id": "ou_133f0b6d0f097cf7d7ba00b38fffb110",
                "creator_user_name": "张三",
                "owner_user_id": "ou_133f0b6d0f097cf7d7ba00b38fffb111",
                "owner_user_name": "张三",
                "form_schema": [
                    {
                        "name": "ou_133f0b6d0f097cf7d7ba00b38fffb112",
                        "type": "张三"
                    }
                ],
                "is_deleted": 0,
                "need_report_user_ids": [
                    "ou_d6a515a55c77ca0b5b6c6ca0dd628c85",
                    "ou_d6a5b5a55c77ca0b5b616c10dd628c55"
                ],
                "need_report_department_ids": [
                    "od_d6s5b5a55c77ca0b5e6c6ca0dd628c85",
                    "od_d6a5b5a55c77ca0b5b6c6ca0dd628c55"
                ],
                "need_report_chat_ids": [
                    "ou_d6a515a55c77ca0b5b6c6ca0dd628c85",
                    "ou_d6a5b5a55c77ca0b5b616ca0dd628c55"
                ],
                "cc_user_ids": [
                    "ou_d6a5b5a55c77ca0b5b6c6c10dd628c85",
                    "ou_d6a5b5a55c77ca0b5b6c6ca0d6628c55"
                ],
                "cc_department_ids": [
                    "od_d6a5b5a55c77ca0b5e6c6ca0dd628c85",
                    "od_d6a5b5a55c77ca0b5b6c6ch0dd628c55"
                ],
                "to_user_ids": [
                    "ou_d6a5b5a55c77ca0b5b6c6ca0dd628c85",
                    "ou_d6a5b5a55c77ca0b5b6c6ca0dd628c55"
                ],
                "to_chat_ids": [
                    "oc_d6a5b5a55c77ca0b5b6c6ca0fd628c85",
                    "oc_d6a5b5a55c77ca0b5b6c1ca0dd628c55"
                ],
                "to_leaders": [0,2,3],
                "to_department_owners": [0,1,2],
                "manager_user_ids": [
                    "ou_d6a5b5a55c77ca0b5b6c6ca0dd628c85",
                    "ou_d6a5b5a55c77ca0b5b6c6ca0dd628c55"
                ],
                "cc_chat_ids": [
                    "oc_d6a5b5a55c77ca0b5b6c6ca0fd628c85",
                    "oc_d6a5b5a55c77ca0b5b6c1ca0dd628c55"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Report.GetReportV1RulesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}