
namespace test2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_web_url = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_star = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_proxy_ip = new System.Windows.Forms.Label();
            this.button_proxy_get = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_last_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_https_check = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_proxy_api = new System.Windows.Forms.TextBox();
            this.button_getproxy_api = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ua = new System.Windows.Forms.TextBox();
            this.button_ua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_showipua = new System.Windows.Forms.Button();
            this.button_showbaidu = new System.Windows.Forms.Button();
            this.button_showxlhhy = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_delete_cache = new System.Windows.Forms.Button();
            this.button_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox_web_url
            // 
            this.textBox_web_url.Location = new System.Drawing.Point(336, 258);
            this.textBox_web_url.Name = "textBox_web_url";
            this.textBox_web_url.Size = new System.Drawing.Size(296, 21);
            this.textBox_web_url.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 373);
            this.textBox2.TabIndex = 2;
            // 
            // button_star
            // 
            this.button_star.Location = new System.Drawing.Point(710, 258);
            this.button_star.Name = "button_star";
            this.button_star.Size = new System.Drawing.Size(69, 21);
            this.button_star.TabIndex = 4;
            this.button_star.Text = "开始访问";
            this.button_star.UseVisualStyleBackColor = true;
            this.button_star.Click += new System.EventHandler(this.button_star_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_proxy_ip
            // 
            this.label_proxy_ip.AutoSize = true;
            this.label_proxy_ip.Location = new System.Drawing.Point(334, 59);
            this.label_proxy_ip.Name = "label_proxy_ip";
            this.label_proxy_ip.Size = new System.Drawing.Size(0, 12);
            this.label_proxy_ip.TabIndex = 6;
            // 
            // button_proxy_get
            // 
            this.button_proxy_get.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_proxy_get.Location = new System.Drawing.Point(637, 95);
            this.button_proxy_get.Name = "button_proxy_get";
            this.button_proxy_get.Size = new System.Drawing.Size(142, 58);
            this.button_proxy_get.TabIndex = 7;
            this.button_proxy_get.Text = "获取代理IP";
            this.button_proxy_get.UseVisualStyleBackColor = true;
            this.button_proxy_get.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(265, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "代理IP：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(265, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "最后检查时间：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_last_time
            // 
            this.label_last_time.AutoSize = true;
            this.label_last_time.Location = new System.Drawing.Point(380, 127);
            this.label_last_time.Name = "label_last_time";
            this.label_last_time.Size = new System.Drawing.Size(0, 12);
            this.label_last_time.TabIndex = 10;
            this.label_last_time.Click += new System.EventHandler(this.label_last_time_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(265, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "是否支持https：";
            // 
            // label_https_check
            // 
            this.label_https_check.AutoSize = true;
            this.label_https_check.Location = new System.Drawing.Point(388, 93);
            this.label_https_check.Name = "label_https_check";
            this.label_https_check.Size = new System.Drawing.Size(0, 12);
            this.label_https_check.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(265, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "代理api获取地址(包含http头）：";
            // 
            // textBox_proxy_api
            // 
            this.textBox_proxy_api.Location = new System.Drawing.Point(465, 23);
            this.textBox_proxy_api.Name = "textBox_proxy_api";
            this.textBox_proxy_api.Size = new System.Drawing.Size(314, 21);
            this.textBox_proxy_api.TabIndex = 14;
            this.textBox_proxy_api.TextChanged += new System.EventHandler(this.textBox_proxy_api_TextChanged);
            // 
            // button_getproxy_api
            // 
            this.button_getproxy_api.Location = new System.Drawing.Point(637, 56);
            this.button_getproxy_api.Name = "button_getproxy_api";
            this.button_getproxy_api.Size = new System.Drawing.Size(142, 33);
            this.button_getproxy_api.TabIndex = 15;
            this.button_getproxy_api.Text = "线路一";
            this.button_getproxy_api.UseVisualStyleBackColor = true;
            this.button_getproxy_api.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(265, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "设置UA：";
            // 
            // textBox_ua
            // 
            this.textBox_ua.Location = new System.Drawing.Point(336, 159);
            this.textBox_ua.Multiline = true;
            this.textBox_ua.Name = "textBox_ua";
            this.textBox_ua.Size = new System.Drawing.Size(296, 71);
            this.textBox_ua.TabIndex = 17;
            this.textBox_ua.TextChanged += new System.EventHandler(this.textBox_ua_TextChanged);
            // 
            // button_ua
            // 
            this.button_ua.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ua.Location = new System.Drawing.Point(638, 159);
            this.button_ua.Name = "button_ua";
            this.button_ua.Size = new System.Drawing.Size(141, 71);
            this.button_ua.TabIndex = 18;
            this.button_ua.Text = "换一个";
            this.button_ua.UseVisualStyleBackColor = true;
            this.button_ua.Click += new System.EventHandler(this.button_ua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(265, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "网址：";
            // 
            // button_showipua
            // 
            this.button_showipua.Location = new System.Drawing.Point(336, 298);
            this.button_showipua.Name = "button_showipua";
            this.button_showipua.Size = new System.Drawing.Size(75, 23);
            this.button_showipua.TabIndex = 20;
            this.button_showipua.Text = "显示IP/UA";
            this.button_showipua.UseVisualStyleBackColor = true;
            this.button_showipua.Click += new System.EventHandler(this.button_showip_Click);
            // 
            // button_showbaidu
            // 
            this.button_showbaidu.Location = new System.Drawing.Point(445, 298);
            this.button_showbaidu.Name = "button_showbaidu";
            this.button_showbaidu.Size = new System.Drawing.Size(75, 23);
            this.button_showbaidu.TabIndex = 22;
            this.button_showbaidu.Text = "显示百度";
            this.button_showbaidu.UseVisualStyleBackColor = true;
            this.button_showbaidu.Click += new System.EventHandler(this.button_showbaidu_Click);
            // 
            // button_showxlhhy
            // 
            this.button_showxlhhy.Location = new System.Drawing.Point(557, 298);
            this.button_showxlhhy.Name = "button_showxlhhy";
            this.button_showxlhhy.Size = new System.Drawing.Size(75, 23);
            this.button_showxlhhy.TabIndex = 23;
            this.button_showxlhhy.Text = "小懒后花园";
            this.button_showxlhhy.UseVisualStyleBackColor = true;
            this.button_showxlhhy.Click += new System.EventHandler(this.button_showxlhhy_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(675, 427);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 12);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "小懒后花园版权所有";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_delete_cache
            // 
            this.button_delete_cache.Location = new System.Drawing.Point(638, 256);
            this.button_delete_cache.Name = "button_delete_cache";
            this.button_delete_cache.Size = new System.Drawing.Size(66, 23);
            this.button_delete_cache.TabIndex = 25;
            this.button_delete_cache.Text = "清除缓存";
            this.button_delete_cache.UseVisualStyleBackColor = true;
            this.button_delete_cache.Click += new System.EventHandler(this.button_delete_cache_Click);
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(665, 285);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(114, 49);
            this.button_go.TabIndex = 26;
            this.button_go.Text = "一键启动";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.button_delete_cache);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_showxlhhy);
            this.Controls.Add(this.button_showbaidu);
            this.Controls.Add(this.button_showipua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_ua);
            this.Controls.Add(this.textBox_ua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_getproxy_api);
            this.Controls.Add(this.textBox_proxy_api);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_https_check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_last_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_proxy_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_proxy_get);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_star);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_web_url);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "站访_0.1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_web_url;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_star;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_proxy_ip;
        private System.Windows.Forms.Button button_proxy_get;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_last_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_https_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_proxy_api;
        private System.Windows.Forms.Button button_getproxy_api;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ua;
        private System.Windows.Forms.Button button_ua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_showipua;
        private System.Windows.Forms.Button button_showbaidu;
        private System.Windows.Forms.Button button_showxlhhy;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_delete_cache;
        private System.Windows.Forms.Button button_go;
    }
}

