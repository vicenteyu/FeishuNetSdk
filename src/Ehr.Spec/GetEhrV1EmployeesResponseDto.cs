namespace FeishuNetSdk.Ehr.Spec;
/// <summary>
/// 批量获取员工花名册信息 响应体
/// <para>根据员工飞书用户 ID / 员工状态 / 雇员类型等搜索条件 ，批量获取员工花名册字段信息。字段包括「系统标准字段 / system_fields」和「自定义字段 / custom_fields」。</para>
/// <para>接口ID：6948366696944648195</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ehr-v1/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fehr%2fehr-v1%2femployee%2flist</para>
/// </summary>
public record GetEhrV1EmployeesResponseDto
{
    /// <summary>
    /// <para>员工列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Employee[]? Items { get; set; }

    /// <summary></summary>
    public record Employee
    {
        /// <summary>
        /// <para>员工的用户 ID</para>
        /// <para>user_id_type 为 user_id 时返回 user_id；</para>
        /// <para>user_id_type 为 open_id 时返回 open_id；</para>
        /// <para>user_id_type 为 union_id 时返回 union_id；</para>
        /// <para>「待入职」和「已取消入职」的员工，此字段值为 null</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>系统字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("system_fields")]
        public SystemField? SystemFields { get; set; }

        /// <summary></summary>
        public record SystemField
        {
            /// <summary>
            /// <para>中文姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>英文姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>手机号码</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>部门的飞书 open_department_id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>上级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("manager")]
            public ManagerSuffix? Manager { get; set; }

            /// <summary></summary>
            public record ManagerSuffix
            {
                /// <summary>
                /// <para>上级的用户 ID（user_id）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string? UserId { get; set; }

                /// <summary>
                /// <para>中文名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>英文名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }
            }

            /// <summary>
            /// <para>职位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job")]
            public JobSuffix? Job { get; set; }

            /// <summary></summary>
            public record JobSuffix
            {
                /// <summary>
                /// <para>职位 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("id")]
                public long? Id { get; set; }

                /// <summary>
                /// <para>职位名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>职级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_level")]
            public JobLevelSuffix? JobLevel { get; set; }

            /// <summary></summary>
            public record JobLevelSuffix
            {
                /// <summary>
                /// <para>职级 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("id")]
                public long? Id { get; set; }

                /// <summary>
                /// <para>职级名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>工作地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_location")]
            public WorkLocationSuffix? WorkLocation { get; set; }

            /// <summary></summary>
            public record WorkLocationSuffix
            {
                /// <summary>
                /// <para>工作地点 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("id")]
                public long? Id { get; set; }

                /// <summary>
                /// <para>工作地点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>性别</para>
            /// <para>**可选值有**：</para>
            /// <para>1:男,2:女</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：男</item>
            /// <item>2：女</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("gender")]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>出生日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("birthday")]
            public string? Birthday { get; set; }

            /// <summary>
            /// <para>籍贯</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("native_region")]
            public NativeRegionSuffix? NativeRegion { get; set; }

            /// <summary></summary>
            public record NativeRegionSuffix
            {
                /// <summary>
                /// <para>ISO 编码</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("iso_code")]
                public string? IsoCode { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>民族</para>
            /// <para>**可选值有**：</para>
            /// <para>1:汉族,2:蒙古族,3:回族,4:藏族,5:维吾尔族,6:苗族,7:彝族,8:壮族,9:布依族,10:朝鲜族,11:满族,12:侗族,13:瑶族,14:白族,15:土家族,16:哈尼族,17:哈萨克族,18:傣族,19:黎族,20:傈僳族,21:佤族,22:畲族,23:高山族,24:拉祜族,25:水族,26:东乡族,27:纳西族,28:景颇族,29:阿昌族,30:柯尔克孜族,31:土族,32:达斡尔族,33:仫佬族,34:羌族,35:布朗族,36:撒拉族,37:毛南族,38:仡佬族,39:锡伯族,40:普米族,41:塔吉克族,42:怒族,43:乌孜别克族,44:俄罗斯族,45:鄂温克族,46:德昂族,47:保安族,48:裕固族,49:京族,50:塔塔尔族,51:独龙族,52:鄂伦春族,53:赫哲族,54:门巴族,55:珞巴族,56:基诺族,57:其他</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：汉族</item>
            /// <item>2：蒙古族</item>
            /// <item>3：回族</item>
            /// <item>4：藏族</item>
            /// <item>5：维吾尔族</item>
            /// <item>6：苗族</item>
            /// <item>7：彝族</item>
            /// <item>8：壮族</item>
            /// <item>9：布依族</item>
            /// <item>10：朝鲜族</item>
            /// <item>11：满族</item>
            /// <item>12：侗族</item>
            /// <item>13：瑶族</item>
            /// <item>14：白族</item>
            /// <item>15：土家族</item>
            /// <item>16：哈尼族</item>
            /// <item>17：哈萨克族</item>
            /// <item>18：傣族</item>
            /// <item>19：黎族</item>
            /// <item>20：傈僳族</item>
            /// <item>21：佤族</item>
            /// <item>22：畲族</item>
            /// <item>23：高山族</item>
            /// <item>24：拉祜族</item>
            /// <item>25：水族</item>
            /// <item>26：东乡族</item>
            /// <item>27：纳西族</item>
            /// <item>28：景颇族</item>
            /// <item>29：阿昌族</item>
            /// <item>30：柯尔克孜族</item>
            /// <item>31：土族</item>
            /// <item>32：达斡尔族</item>
            /// <item>33：仫佬族</item>
            /// <item>34：羌族</item>
            /// <item>35：布朗族</item>
            /// <item>36：撒拉族</item>
            /// <item>37：毛南族</item>
            /// <item>38：仡佬族</item>
            /// <item>39：锡伯族</item>
            /// <item>40：普米族</item>
            /// <item>41：塔吉克族</item>
            /// <item>42：怒族</item>
            /// <item>43：乌孜别克族</item>
            /// <item>44：俄罗斯族</item>
            /// <item>45：鄂温克族</item>
            /// <item>46：德昂族</item>
            /// <item>47：保安族</item>
            /// <item>48：裕固族</item>
            /// <item>49：京族</item>
            /// <item>50：塔塔尔族</item>
            /// <item>51：独龙族</item>
            /// <item>52：鄂伦春族</item>
            /// <item>53：赫哲族</item>
            /// <item>54：门巴族</item>
            /// <item>55：珞巴族</item>
            /// <item>56：基诺族</item>
            /// <item>57：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("ethnicity")]
            public int? Ethnicity { get; set; }

            /// <summary>
            /// <para>婚姻状况</para>
            /// <para>**可选值有**：</para>
            /// <para>1:未婚,2:已婚,3:离异,4:其他</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未婚</item>
            /// <item>2：已婚</item>
            /// <item>3：离异</item>
            /// <item>4：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("marital_status")]
            public int? MaritalStatus { get; set; }

            /// <summary>
            /// <para>政治面貌</para>
            /// <para>**可选值有**：</para>
            /// <para>1:中共党员,2:中国农工民主党,3:中国国民党革命委员会,4:中国民主促进会会员,5:中国民主同盟成员,6:中国民主建国会,7:中国致公党党员,8:九三学社社员,9:共青团员,10:其它党派成员,11:民主人士,12:群众,13:台湾民主自治同盟盟员</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：中共党员</item>
            /// <item>2：中国农工民主党</item>
            /// <item>3：中国国民党革命委员会</item>
            /// <item>4：中国民主促进会会员</item>
            /// <item>5：中国民主同盟成员</item>
            /// <item>6：中国民主建国会</item>
            /// <item>7：中国致公党党员</item>
            /// <item>8：九三学社社员</item>
            /// <item>9：共青团员</item>
            /// <item>10：其它党派成员</item>
            /// <item>11：民主人士</item>
            /// <item>12：群众</item>
            /// <item>13：台湾民主自治同盟盟员</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("political_status")]
            public int? PoliticalStatus { get; set; }

            /// <summary>
            /// <para>参加工作日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("entered_workforce_date")]
            public string? EnteredWorkforceDate { get; set; }

            /// <summary>
            /// <para>证件类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:居民身份证,2:港澳居民来往内地通行证,3:台湾居民来往大陆通行证,4:护照,5:其他</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居民身份证</item>
            /// <item>2：港澳居民来往内地通行证</item>
            /// <item>3：台湾居民来往大陆通行证</item>
            /// <item>4：护照</item>
            /// <item>5：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("id_type")]
            public int? IdType { get; set; }

            /// <summary>
            /// <para>证件号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id_number")]
            public string? IdNumber { get; set; }

            /// <summary>
            /// <para>户口类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:本市城镇,2:外埠城镇,3:本市农村,4:外埠农村</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：本市城镇</item>
            /// <item>2：外埠城镇</item>
            /// <item>3：本市农村</item>
            /// <item>4：外埠农村</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("hukou_type")]
            public int? HukouType { get; set; }

            /// <summary>
            /// <para>户口所在地</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hukou_location")]
            public string? HukouLocation { get; set; }

            /// <summary>
            /// <para>银行卡号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank_account_number")]
            public string? BankAccountNumber { get; set; }

            /// <summary>
            /// <para>开户行</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank_name")]
            public string? BankName { get; set; }

            /// <summary>
            /// <para>社保账号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("social_security_account")]
            public string? SocialSecurityAccount { get; set; }

            /// <summary>
            /// <para>公积金账号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("provident_fund_account")]
            public string? ProvidentFundAccount { get; set; }

            /// <summary>
            /// <para>工号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_no")]
            public string? EmployeeNo { get; set; }

            /// <summary>
            /// <para>人员类型</para>
            /// <para>同时可读取到自定义员工类型的 int 值，可通过下方接口获取到该租户的自定义员工类型的名称，参见 [获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)</para>
            /// <para>**可选值有**：</para>
            /// <para>1:正式,2:实习,3:顾问,4:外包,5:劳务</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：正式</item>
            /// <item>2：实习</item>
            /// <item>3：顾问</item>
            /// <item>4：外包</item>
            /// <item>5：劳务</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("employee_type")]
            public int? EmployeeType { get; set; }

            /// <summary>
            /// <para>员工状态</para>
            /// <para>**可选值有**：</para>
            /// <para>1:待入职,2:在职,3:已取消入职,4:待离职,5:已离职</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：待入职</item>
            /// <item>2：在职</item>
            /// <item>3：已取消入职</item>
            /// <item>4：待离职</item>
            /// <item>5：已离职</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// <para>入职日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hire_date")]
            public string? HireDate { get; set; }

            /// <summary>
            /// <para>试用期（月）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("probation_months")]
            public float? ProbationMonths { get; set; }

            /// <summary>
            /// <para>转正日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("conversion_date")]
            public string? ConversionDate { get; set; }

            /// <summary>
            /// <para>转正申请</para>
            /// <para>**可选值有**：</para>
            /// <para>1:未申请,2:审批中,3:被驳回,4:已通过</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未申请</item>
            /// <item>2：审批中</item>
            /// <item>3：被驳回</item>
            /// <item>4：已通过</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("application")]
            public int? Application { get; set; }

            /// <summary>
            /// <para>转正状态</para>
            /// <para>**可选值有**：</para>
            /// <para>1:无需转正,2:待转正,3:已转正</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：无需转正</item>
            /// <item>2：待转正</item>
            /// <item>3：已转正</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("application_status")]
            public int? ApplicationStatus { get; set; }

            /// <summary>
            /// <para>离职日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("last_day")]
            public string? LastDay { get; set; }

            /// <summary>
            /// <para>离职类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:主动,2:被动,3:其他</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：主动</item>
            /// <item>2：被动</item>
            /// <item>3：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("departure_type")]
            public int? DepartureType { get; set; }

            /// <summary>
            /// <para>离职原因</para>
            /// <para>**可选值有**：</para>
            /// <para>1:身体、家庭原因,2:职业发展,3:薪资福利不满意,4:工作压力大,5:合同到期不续签,6:其他,7:无法胜任工作,8:组织业务调整和岗位优化,9:违反公司条例,10:试用期未通过,11:其他,12:不满意工作内容,13:不认可上级或管理层,14:对公司文化缺乏认同,15:组织架构调整（主动离职）,16:跳槽,17:转行,18:家庭原因,19:健康状况不佳,20:工作地点原因,21:意外,22:身故,23:解雇,24:工作产出低,25:违法,26:其他（其他）</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：身体、家庭原因</item>
            /// <item>2：职业发展</item>
            /// <item>3：薪资福利不满意</item>
            /// <item>4：工作压力大</item>
            /// <item>5：合同到期不续签</item>
            /// <item>6：其他</item>
            /// <item>7：无法胜任工作</item>
            /// <item>8：组织业务调整和岗位优化</item>
            /// <item>9：违反公司条例</item>
            /// <item>10：试用期未通过</item>
            /// <item>11：其他</item>
            /// <item>12：不满意工作内容</item>
            /// <item>13：不认可上级或管理层</item>
            /// <item>14：对公司文化缺乏认同</item>
            /// <item>15：组织架构调整（主动离职）</item>
            /// <item>16：跳槽</item>
            /// <item>17：转行</item>
            /// <item>18：家庭原因</item>
            /// <item>19：健康状况不佳</item>
            /// <item>20：工作地点原因</item>
            /// <item>21：意外</item>
            /// <item>22：身故</item>
            /// <item>23：解雇</item>
            /// <item>24：工作产出低</item>
            /// <item>25：违法</item>
            /// <item>26：其他（其他）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("departure_reason")]
            public int? DepartureReason { get; set; }

            /// <summary>
            /// <para>离职备注</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("departure_notes")]
            public string? DepartureNotes { get; set; }

            /// <summary>
            /// <para>合同公司</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contract_company")]
            public ContractCompanySuffix? ContractCompany { get; set; }

            /// <summary></summary>
            public record ContractCompanySuffix
            {
                /// <summary>
                /// <para>公司 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("id")]
                public long? Id { get; set; }

                /// <summary>
                /// <para>公司名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>合同类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:固定期限劳动合同,2:无固定期限劳动合同,3:实习协议,4:外包协议,5:劳务派遣合同,6:返聘协议,7:其他</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：固定期限劳动合同</item>
            /// <item>2：无固定期限劳动合同</item>
            /// <item>3：实习协议</item>
            /// <item>4：外包协议</item>
            /// <item>5：劳务派遣合同</item>
            /// <item>6：返聘协议</item>
            /// <item>7：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("contract_type")]
            public int? ContractType { get; set; }

            /// <summary>
            /// <para>合同开始日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contract_start_date")]
            public string? ContractStartDate { get; set; }

            /// <summary>
            /// <para>合同到期日期</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contract_expiration_date")]
            public string? ContractExpirationDate { get; set; }

            /// <summary>
            /// <para>劳动合同签订次数</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contract_sign_times")]
            public int? ContractSignTimes { get; set; }

            /// <summary>
            /// <para>个人邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("personal_email")]
            public string? PersonalEmail { get; set; }

            /// <summary>
            /// <para>家庭地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("family_address")]
            public string? FamilyAddress { get; set; }

            /// <summary>
            /// <para>主要紧急联系人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("primary_emergency_contact")]
            public EmergencyContact? PrimaryEmergencyContact { get; set; }

            /// <summary>
            /// <para>紧急联系人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("emergency_contact")]
            public EmergencyContact[]? EmergencyContacts { get; set; }

            /// <summary></summary>
            public record EmergencyContact
            {
                /// <summary>
                /// <para>紧急联系人姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>与紧急联系人的关系</para>
                /// <para>**可选值有**：</para>
                /// <para>1:父母,2:配偶,3:子女,4:兄弟姐妹,5:朋友,6:其他</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：父母</item>
                /// <item>2：配偶</item>
                /// <item>3：子女</item>
                /// <item>4：兄弟姐妹</item>
                /// <item>5：朋友</item>
                /// <item>6：其他</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public int? Relationship { get; set; }

                /// <summary>
                /// <para>手机号</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile")]
                public string? Mobile { get; set; }
            }

            /// <summary>
            /// <para>最高学历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highest_level_of_edu")]
            public Education? HighestLevelOfEdu { get; set; }

            /// <summary>
            /// <para>教育经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("education")]
            public Education[]? Educations { get; set; }

            /// <summary></summary>
            public record Education
            {
                /// <summary>
                /// <para>学历</para>
                /// <para>**可选值有**：</para>
                /// <para>1:小学,2:初中,3:高中,4:职业高级中学,5:中等专业学校,6:大专,7:本科,8:硕士,9:博士</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：小学</item>
                /// <item>2：初中</item>
                /// <item>3：高中</item>
                /// <item>4：职业高级中学</item>
                /// <item>5：中等专业学校</item>
                /// <item>6：大专</item>
                /// <item>7：本科</item>
                /// <item>8：硕士</item>
                /// <item>9：博士</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("level")]
                public int? Level { get; set; }

                /// <summary>
                /// <para>毕业学校</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("school")]
                public string? School { get; set; }

                /// <summary>
                /// <para>专业</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("major")]
                public string? Major { get; set; }

                /// <summary>
                /// <para>学位</para>
                /// <para>**可选值有**：</para>
                /// <para>1:学士,2:硕士,3:博士</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：学士</item>
                /// <item>2：硕士</item>
                /// <item>3：博士</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("degree")]
                public int? Degree { get; set; }

                /// <summary>
                /// <para>开始日期</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("start")]
                public string? Start { get; set; }

                /// <summary>
                /// <para>结束日期</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("end")]
                public string? End { get; set; }
            }

            /// <summary>
            /// <para>前工作经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("former_work_exp")]
            public WorkExperience? FormerWorkExp { get; set; }

            /// <summary>
            /// <para>工作经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_exp")]
            public WorkExperience[]? WorkExp { get; set; }

            /// <summary></summary>
            public record WorkExperience
            {
                /// <summary>
                /// <para>公司</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("company")]
                public string? Company { get; set; }

                /// <summary>
                /// <para>部门</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department")]
                public string? Department { get; set; }

                /// <summary>
                /// <para>职位</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job")]
                public string? Job { get; set; }

                /// <summary>
                /// <para>开始日期</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("start")]
                public string? Start { get; set; }

                /// <summary>
                /// <para>截止日期</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("end")]
                public string? End { get; set; }

                /// <summary>
                /// <para>工作描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public string? Description { get; set; }
            }

            /// <summary>
            /// <para>身份证照片（人像面）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id_photo_po_side")]
            public Attachment[]? IdPhotoPoSide { get; set; }

            /// <summary>
            /// <para>身份证照片（国徽面）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id_photo_em_side")]
            public Attachment[]? IdPhotoEmSide { get; set; }

            /// <summary>
            /// <para>证件照</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id_photo")]
            public Attachment[]? IdPhoto { get; set; }

            /// <summary>
            /// <para>学位证书</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("diploma_photo")]
            public Attachment[]? DiplomaPhoto { get; set; }

            /// <summary>
            /// <para>毕业证书</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("graduation_cert")]
            public Attachment[]? GraduationCert { get; set; }

            /// <summary>
            /// <para>奖励证明</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cert_of_merit")]
            public Attachment[]? CertOfMerit { get; set; }

            /// <summary>
            /// <para>离职证明</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offboarding_file")]
            public Attachment[]? OffboardingFile { get; set; }

            /// <summary>
            /// <para>取消入职原因</para>
            /// <para>**可选值有**：</para>
            /// <para>1:个人原因,2:原单位留任,3:接受其他 Offer,4:其他</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：个人原因</item>
            /// <item>2：原单位留任</item>
            /// <item>3：接受其他Offer</item>
            /// <item>4：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("cancel_onboarding_reason")]
            public int? CancelOnboardingReason { get; set; }

            /// <summary>
            /// <para>取消入职备注</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cancel_onboarding_notes")]
            public string? CancelOnboardingNotes { get; set; }

            /// <summary>
            /// <para>入职登记表状态</para>
            /// <para>**可选值有**：</para>
            /// <para>1:未发送,2:待提交,3:已提交</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未发送</item>
            /// <item>2：待提交</item>
            /// <item>3：已提交</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("employee_form_status")]
            public int? EmployeeFormStatus { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public int? CreateTime { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public int? UpdateTime { get; set; }

            /// <summary></summary>
            public record Attachment
            {
                /// <summary>
                /// <para>下载文件所需要的 Token</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>文件类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mime_type")]
                public string? MimeType { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>大小</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("size")]
                public long? Size { get; set; }

            }
        }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomField[]? CustomFields { get; set; }

        /// <summary></summary>
        public record CustomField
        {
            /// <summary>
            /// <para>自定义字段key</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string? Key { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("label")]
            public string? Label { get; set; }

            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>**可选值有**：</para>
            /// <para>text:文本类型,date:日期类型，如 2020-01-01,option:枚举类型,file:附件类型</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>text：文本类型</item>
            /// <item>date：日期类型，如2020-01-01</item>
            /// <item>option：枚举类型</item>
            /// <item>file：附件类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>根据 type 不同，结构不同，不同 type 对应的数据结构在 type 的枚举值中有描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
