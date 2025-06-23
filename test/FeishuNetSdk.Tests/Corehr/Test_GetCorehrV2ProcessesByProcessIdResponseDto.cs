namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取单个流程详情 响应体
/// <para>接口ID：7296819819722588188</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2ProcessesByProcessIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "process_id": "7278949005675988535",
        "status": 1,
        "flow_template_id": "leave",
        "flow_template_name": {
            "zh_cn": "中文",
            "en_us": "English"
        },
        "flow_definition_id": "people_6961286846093788680_7081951411982077732",
        "flow_definition_name": {
            "zh_cn": "中文",
            "en_us": "English"
        },
        "initiator_id": "7124991993901827628",
        "initiator_name": {
            "zh_cn": "中文",
            "en_us": "English"
        },
        "create_time": "1694769814036",
        "complete_time": "1694769814036",
        "start_links": {
            "web_link": "http://xxxx.com/xxx/xxx?a=b",
            "pc_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx",
            "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx"
        },
        "abstracts": [
            {
                "name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "value": {
                    "zh_cn": "中文",
                    "en_us": "English"
                }
            }
        ],
        "todos": [
            {
                "approver_id": "7278949005675988535",
                "type": 1,
                "links": {
                    "web_link": "http://xxxx.com/xxx/xxx?a=b",
                    "pc_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx",
                    "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx"
                },
                "operator_id": "7124991993901827628",
                "operator_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "node_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "create_time": "1694769814036",
                "node_definition_id": "approval_d25b5eddfef"
            }
        ],
        "cc_list": [
            {
                "approver_id": "7278949005675988535",
                "links": {
                    "web_link": "http://xxxx.com/xxx/xxx?a=b",
                    "pc_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx",
                    "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx"
                },
                "operator_id": "7124991993901827628",
                "operator_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "node_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "create_time": "1694769814036",
                "node_definition_id": "approval_d25b5eddfef"
            }
        ],
        "done_list": [
            {
                "approver_id": "7278949005675988535",
                "type": 1,
                "status": 3,
                "links": {
                    "web_link": "http://xxxx.com/xxx/xxx?a=b",
                    "pc_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx",
                    "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx"
                },
                "operator_id": "7124991993901827628",
                "operator_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "node_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "create_time": "1694769814036",
                "complete_time": "1694769814036",
                "node_definition_id": "approval_d25b5eddfef",
                "approval_opinion": "审批意见"
            }
        ],
        "properties": 1,
        "system_todos": [
            {
                "approver_id": "7278949005675988535",
                "type": 1,
                "links": {
                    "web_link": "http://xxxx.com/xxx/xxx?a=b",
                    "pc_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx",
                    "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx"
                },
                "operator_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "node_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "create_time": "1694769814036",
                "node_definition_id": "approval_d25b5eddfef"
            }
        ],
        "system_done_list": [
            {
                "approver_id": "7278949005675988535",
                "type": 1,
                "status": 3,
                "links": {
                    "web_link": "http://xxxx.com/xxx/xxx?a=b",
                    "pc_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx",
                    "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=xxx"
                },
                "operator_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "node_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "create_time": "1694769814036",
                "complete_time": "1694769814036",
                "node_definition_id": "approval_d25b5eddfef",
                "approval_opinion": "审批意见"
            }
        ],
        "comment_infos": [
            {
                "commentor_id": "7355397217231831060",
                "commentor_name": {
                    "zh_cn": "中文",
                    "en_us": "English"
                },
                "comment_time": "1694769814036",
                "comment_msg": "评论内容"
            }
        ],
        "original_process_id": "7278949005675988535",
        "is_last_completed_correct_process": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2ProcessesByProcessIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}