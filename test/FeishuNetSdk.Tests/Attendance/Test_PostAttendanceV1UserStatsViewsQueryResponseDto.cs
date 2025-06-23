namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询统计设置 响应体
/// <para>接口ID：7044467124773830657</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_view%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserStatsViewsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "",
    "data": {
        "view": {
            "items": [
                {
                    "child_items": [
                        {
                            "code": "50101",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": true,
                            "title": "姓名",
                            "value": "1"
                        },
                        {
                            "code": "50102",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "部门",
                            "value": "0"
                        },
                        {
                            "code": "50111",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "组织架构",
                            "value": "0"
                        },
                        {
                            "code": "50103",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "工号",
                            "value": "1"
                        },
                        {
                            "code": "50104",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "邮箱",
                            "value": "0"
                        },
                        {
                            "code": "50105",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "雇员类型",
                            "value": "0"
                        },
                        {
                            "code": "50106",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "序列",
                            "value": "0"
                        },
                        {
                            "code": "50107",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "入职时间",
                            "value": "0"
                        },
                        {
                            "code": "50108",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "离职时间",
                            "value": "0"
                        },
                        {
                            "code": "50109",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "状态",
                            "value": "0"
                        },
                        {
                            "code": "50110",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "直属上级",
                            "value": "0"
                        }
                    ],
                    "code": "501",
                    "title": "基本信息"
                },
                {
                    "child_items": [
                        {
                            "code": "52108",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "考勤组名称",
                            "value": "1"
                        },
                        {
                            "code": "52101",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "应出勤天数",
                            "value": "1"
                        },
                        {
                            "code": "52102",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "工作日出勤天数",
                            "value": "1"
                        },
                        {
                            "code": "52103",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "休息日出勤天数",
                            "value": "0"
                        },
                        {
                            "code": "52104",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "应出勤时长",
                            "value": "1"
                        },
                        {
                            "code": "52105",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "实际出勤时长",
                            "value": "1"
                        },
                        {
                            "code": "52106",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "计薪工作时长",
                            "value": "0"
                        },
                        {
                            "code": "52107",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "加班工作时长",
                            "value": "1"
                        },
                        {
                            "code": "52109",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "加班时长(计加班费)\n",
                            "value": "0"
                        },
                        {
                            "code": "52110",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "加班时长(计为调休)\n",
                            "value": "0"
                        }
                    ],
                    "code": "521",
                    "title": "出勤统计"
                },
                {
                    "child_items": [
                        {
                            "code": "52201",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "迟到次数",
                            "value": "1"
                        },
                        {
                            "code": "52202",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "迟到时长",
                            "value": "0"
                        },
                        {
                            "code": "52203",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "早退次数",
                            "value": "1"
                        },
                        {
                            "code": "52204",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "早退时长",
                            "value": "0"
                        },
                        {
                            "code": "52205",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "上班缺卡次数",
                            "value": "0"
                        },
                        {
                            "code": "52206",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "下班缺卡次数",
                            "value": "0"
                        },
                        {
                            "code": "52207",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "缺勤",
                            "value": "1"
                        },
                        {
                            "code": "52208",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "请假时长",
                            "value": "0"
                        },
                        {
                            "code": "52209",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "出差时长",
                            "value": "0"
                        },
                        {
                            "code": "52211",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "换班天数",
                            "value": "0"
                        },
                        {
                            "code": "52212",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "补卡次数",
                            "value": "0"
                        },
                        {
                            "code": "52213",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "外勤次数",
                            "value": "0"
                        },
                        {
                            "code": "52214",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "外出时长\t",
                            "value": "0"
                        }
                    ],
                    "code": "522",
                    "title": "异常统计"
                },
                {
                    "child_items": [
                        {
                            "code": "52401",
                            "column_type": 0,
                            "max_value": "",
                            "min_value": "",
                            "read_only": false,
                            "title": "每日考勤结果",
                            "value": "1"
                        }
                    ],
                    "code": "524",
                    "title": "每日统计"
                }
            ],
            "stats_type": "month",
            "user_id": "ec8ddg56",
            "view_id": "TmpZNU5qTTJORFF6T1RnNU5UTTNOakV6TWl0dGIyNTBhQT09"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserStatsViewsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}