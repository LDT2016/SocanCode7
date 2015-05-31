using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// ���ݿ��
    /// </summary>
    public class Table
    {
        /// <summary>
        /// ����һ�������ݿ��
        /// </summary>
        public Table()
        {
            this.Fields = new List<Field>();
        }

        #region ����
        /// <summary>
        /// �������Ŀ�
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public Database Database { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �Ƿ�����ͼ
        /// </summary>
        public bool IsView { get; set; }

        /// <summary>
        /// ���е�������
        /// </summary>
        public List<Model.Field> Fields { get; set; }
        #endregion

        #region ����
        /// <summary>
        /// ���һ���ֶ�
        /// </summary>
        public void AddField(Model.Field field)
        {
            field.Table = this;
            Fields.Add(field);
        }

        /// <summary>
        /// ת��Ϊ�ַ���
        /// </summary>
        /// <returns>���ر���</returns>
        public override string ToString()
        {
            return this.Name;
        }
        #endregion
    }
}
