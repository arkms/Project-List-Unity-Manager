/*
 * Created by SharpDevelop.
 * User: Arkms
 * Date: 18/12/2013
 * Time: 7:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
#define UNITY_5
 
using System;
using System.Collections.Generic;
using Utility.ModifyRegistry;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Text;

namespace Project_List_Unity_Manager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public partial class MainForm : Form
	{
		ModifyRegistry regris= new ModifyRegistry();
		List<string> ListaRegistro = new List<string>();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			regris.BaseRegistryKey= Registry.CurrentUser;
			#if UNITY_5
			regris.SubKey= "Software\\Unity Technologies\\Unity Editor 5.x";
			#else
			regris.SubKey= "Software\\Unity Technologies\\Unity Editor 4.x";
			#endif
			
			Refrescar();
		}
		
		void Refrescar()
		{
			RegistryKey HKLM = Registry.CurrentUser;
			#if UNITY_5
            RegistryKey RegKey = HKLM.OpenSubKey("Software\\Unity Technologies\\Unity Editor 5.x");
            #else
            RegistryKey RegKey = HKLM.OpenSubKey("Software\\Unity Technologies\\Unity Editor 4.x");
            #endif
            string[] subKeys = RegKey.GetValueNames();	
            			
            ListProjectsBox.Items.Clear();
            ListaRegistro.Clear();
            foreach (string subKey in subKeys)
            {
            	if(subKey.StartsWith("RecentlyUsedProjectPaths"))
            	{
            		#if UNITY_5
            		string path= new string(Encoding.Default.GetChars((byte[])RegKey.GetValue(subKey)));
            		ListProjectsBox.Items.Add(path);
            		#else
            		ListProjectsBox.Items.Add(regris.Read(subKey));
            		#endif
            		ListaRegistro.Add(subKey);
            	}
            }
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(ListProjectsBox.Items.Count == 0) return;
			
			List<int> IndicesBorrar = new List<int>();
			int size = ListProjectsBox.Items.Count;
			//Buscamos todos los seleccionados y agregamos a lista a borrar
			for(int i=0; i<size; i++)
			{
				if(ListProjectsBox.GetItemChecked(i))
				{
					IndicesBorrar.Add(i);
				}
			}
			
			size = IndicesBorrar.Count;//Cambiamos size a Indices Borrar
			for(int i=0; i<size; i++)
			{
				//Eliminamos del registro
				regris.DeleteKey(ListaRegistro[IndicesBorrar[i]]);
			}
			
			Refrescar();
		}
	}
}
