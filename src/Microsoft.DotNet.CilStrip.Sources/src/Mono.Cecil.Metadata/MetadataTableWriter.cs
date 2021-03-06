//
// MetadataTableWriter.cs
//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Generated by /CodeGen/cecil-gen.rb do not edit
// Thu Feb 22 14:39:38 CET 2007
//
// (C) 2005 Jb Evain
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace CilStrip.Mono.Cecil.Metadata {

	using System;
	using System.Collections;

	using CilStrip.Mono.Cecil.Binary;

	internal sealed class MetadataTableWriter : BaseMetadataTableVisitor {

		MetadataRoot m_root;
		TablesHeap m_heap;
		MetadataRowWriter m_mrrw;
		MemoryBinaryWriter m_binaryWriter;

		public MetadataTableWriter (MetadataWriter mrv, MemoryBinaryWriter writer)
		{
			m_root = mrv.GetMetadataRoot ();
			m_heap = m_root.Streams.TablesHeap;
			m_binaryWriter = writer;
			m_mrrw = new MetadataRowWriter (this);
		}

		public MetadataRoot GetMetadataRoot ()
		{
			return m_root;
		}

		public override IMetadataRowVisitor GetRowVisitor ()
		{
			return m_mrrw;
		}

		public MemoryBinaryWriter GetWriter ()
		{
			return m_binaryWriter;
		}

		void InitializeTable (IMetadataTable table)
		{
			table.Rows = new RowCollection ();
			m_heap.Valid |= 1L << table.Id;
			m_heap.Tables.Add (table);
		}

		void WriteCount (int rid)
		{
			if (m_heap.HasTable (rid))
				m_binaryWriter.Write (m_heap [rid].Rows.Count);
		}

		public AssemblyTable GetAssemblyTable ()
		{
			AssemblyTable table = m_heap [AssemblyTable.RId] as AssemblyTable;
			if (table != null)
				return table;

			table = new AssemblyTable ();
			InitializeTable (table);
			return table;
		}

		public AssemblyOSTable GetAssemblyOSTable ()
		{
			AssemblyOSTable table = m_heap [AssemblyOSTable.RId] as AssemblyOSTable;
			if (table != null)
				return table;

			table = new AssemblyOSTable ();
			InitializeTable (table);
			return table;
		}

		public AssemblyProcessorTable GetAssemblyProcessorTable ()
		{
			AssemblyProcessorTable table = m_heap [AssemblyProcessorTable.RId] as AssemblyProcessorTable;
			if (table != null)
				return table;

			table = new AssemblyProcessorTable ();
			InitializeTable (table);
			return table;
		}

		public AssemblyRefTable GetAssemblyRefTable ()
		{
			AssemblyRefTable table = m_heap [AssemblyRefTable.RId] as AssemblyRefTable;
			if (table != null)
				return table;

			table = new AssemblyRefTable ();
			InitializeTable (table);
			return table;
		}

		public AssemblyRefOSTable GetAssemblyRefOSTable ()
		{
			AssemblyRefOSTable table = m_heap [AssemblyRefOSTable.RId] as AssemblyRefOSTable;
			if (table != null)
				return table;

			table = new AssemblyRefOSTable ();
			InitializeTable (table);
			return table;
		}

		public AssemblyRefProcessorTable GetAssemblyRefProcessorTable ()
		{
			AssemblyRefProcessorTable table = m_heap [AssemblyRefProcessorTable.RId] as AssemblyRefProcessorTable;
			if (table != null)
				return table;

			table = new AssemblyRefProcessorTable ();
			InitializeTable (table);
			return table;
		}

		public ClassLayoutTable GetClassLayoutTable ()
		{
			ClassLayoutTable table = m_heap [ClassLayoutTable.RId] as ClassLayoutTable;
			if (table != null)
				return table;

			table = new ClassLayoutTable ();
			InitializeTable (table);
			return table;
		}

		public ConstantTable GetConstantTable ()
		{
			ConstantTable table = m_heap [ConstantTable.RId] as ConstantTable;
			if (table != null)
				return table;

			table = new ConstantTable ();
			InitializeTable (table);
			return table;
		}

		public CustomAttributeTable GetCustomAttributeTable ()
		{
			CustomAttributeTable table = m_heap [CustomAttributeTable.RId] as CustomAttributeTable;
			if (table != null)
				return table;

			table = new CustomAttributeTable ();
			InitializeTable (table);
			return table;
		}

		public DeclSecurityTable GetDeclSecurityTable ()
		{
			DeclSecurityTable table = m_heap [DeclSecurityTable.RId] as DeclSecurityTable;
			if (table != null)
				return table;

			table = new DeclSecurityTable ();
			InitializeTable (table);
			return table;
		}

		public EventTable GetEventTable ()
		{
			EventTable table = m_heap [EventTable.RId] as EventTable;
			if (table != null)
				return table;

			table = new EventTable ();
			InitializeTable (table);
			return table;
		}

		public EventMapTable GetEventMapTable ()
		{
			EventMapTable table = m_heap [EventMapTable.RId] as EventMapTable;
			if (table != null)
				return table;

			table = new EventMapTable ();
			InitializeTable (table);
			return table;
		}

		public EventPtrTable GetEventPtrTable ()
		{
			EventPtrTable table = m_heap [EventPtrTable.RId] as EventPtrTable;
			if (table != null)
				return table;

			table = new EventPtrTable ();
			InitializeTable (table);
			return table;
		}

		public ExportedTypeTable GetExportedTypeTable ()
		{
			ExportedTypeTable table = m_heap [ExportedTypeTable.RId] as ExportedTypeTable;
			if (table != null)
				return table;

			table = new ExportedTypeTable ();
			InitializeTable (table);
			return table;
		}

		public FieldTable GetFieldTable ()
		{
			FieldTable table = m_heap [FieldTable.RId] as FieldTable;
			if (table != null)
				return table;

			table = new FieldTable ();
			InitializeTable (table);
			return table;
		}

		public FieldLayoutTable GetFieldLayoutTable ()
		{
			FieldLayoutTable table = m_heap [FieldLayoutTable.RId] as FieldLayoutTable;
			if (table != null)
				return table;

			table = new FieldLayoutTable ();
			InitializeTable (table);
			return table;
		}

		public FieldMarshalTable GetFieldMarshalTable ()
		{
			FieldMarshalTable table = m_heap [FieldMarshalTable.RId] as FieldMarshalTable;
			if (table != null)
				return table;

			table = new FieldMarshalTable ();
			InitializeTable (table);
			return table;
		}

		public FieldPtrTable GetFieldPtrTable ()
		{
			FieldPtrTable table = m_heap [FieldPtrTable.RId] as FieldPtrTable;
			if (table != null)
				return table;

			table = new FieldPtrTable ();
			InitializeTable (table);
			return table;
		}

		public FieldRVATable GetFieldRVATable ()
		{
			FieldRVATable table = m_heap [FieldRVATable.RId] as FieldRVATable;
			if (table != null)
				return table;

			table = new FieldRVATable ();
			InitializeTable (table);
			return table;
		}

		public FileTable GetFileTable ()
		{
			FileTable table = m_heap [FileTable.RId] as FileTable;
			if (table != null)
				return table;

			table = new FileTable ();
			InitializeTable (table);
			return table;
		}

		public GenericParamTable GetGenericParamTable ()
		{
			GenericParamTable table = m_heap [GenericParamTable.RId] as GenericParamTable;
			if (table != null)
				return table;

			table = new GenericParamTable ();
			InitializeTable (table);
			return table;
		}

		public GenericParamConstraintTable GetGenericParamConstraintTable ()
		{
			GenericParamConstraintTable table = m_heap [GenericParamConstraintTable.RId] as GenericParamConstraintTable;
			if (table != null)
				return table;

			table = new GenericParamConstraintTable ();
			InitializeTable (table);
			return table;
		}

		public ImplMapTable GetImplMapTable ()
		{
			ImplMapTable table = m_heap [ImplMapTable.RId] as ImplMapTable;
			if (table != null)
				return table;

			table = new ImplMapTable ();
			InitializeTable (table);
			return table;
		}

		public InterfaceImplTable GetInterfaceImplTable ()
		{
			InterfaceImplTable table = m_heap [InterfaceImplTable.RId] as InterfaceImplTable;
			if (table != null)
				return table;

			table = new InterfaceImplTable ();
			InitializeTable (table);
			return table;
		}

		public ManifestResourceTable GetManifestResourceTable ()
		{
			ManifestResourceTable table = m_heap [ManifestResourceTable.RId] as ManifestResourceTable;
			if (table != null)
				return table;

			table = new ManifestResourceTable ();
			InitializeTable (table);
			return table;
		}

		public MemberRefTable GetMemberRefTable ()
		{
			MemberRefTable table = m_heap [MemberRefTable.RId] as MemberRefTable;
			if (table != null)
				return table;

			table = new MemberRefTable ();
			InitializeTable (table);
			return table;
		}

		public MethodTable GetMethodTable ()
		{
			MethodTable table = m_heap [MethodTable.RId] as MethodTable;
			if (table != null)
				return table;

			table = new MethodTable ();
			InitializeTable (table);
			return table;
		}

		public MethodImplTable GetMethodImplTable ()
		{
			MethodImplTable table = m_heap [MethodImplTable.RId] as MethodImplTable;
			if (table != null)
				return table;

			table = new MethodImplTable ();
			InitializeTable (table);
			return table;
		}

		public MethodPtrTable GetMethodPtrTable ()
		{
			MethodPtrTable table = m_heap [MethodPtrTable.RId] as MethodPtrTable;
			if (table != null)
				return table;

			table = new MethodPtrTable ();
			InitializeTable (table);
			return table;
		}

		public MethodSemanticsTable GetMethodSemanticsTable ()
		{
			MethodSemanticsTable table = m_heap [MethodSemanticsTable.RId] as MethodSemanticsTable;
			if (table != null)
				return table;

			table = new MethodSemanticsTable ();
			InitializeTable (table);
			return table;
		}

		public MethodSpecTable GetMethodSpecTable ()
		{
			MethodSpecTable table = m_heap [MethodSpecTable.RId] as MethodSpecTable;
			if (table != null)
				return table;

			table = new MethodSpecTable ();
			InitializeTable (table);
			return table;
		}

		public ModuleTable GetModuleTable ()
		{
			ModuleTable table = m_heap [ModuleTable.RId] as ModuleTable;
			if (table != null)
				return table;

			table = new ModuleTable ();
			InitializeTable (table);
			return table;
		}

		public ModuleRefTable GetModuleRefTable ()
		{
			ModuleRefTable table = m_heap [ModuleRefTable.RId] as ModuleRefTable;
			if (table != null)
				return table;

			table = new ModuleRefTable ();
			InitializeTable (table);
			return table;
		}

		public NestedClassTable GetNestedClassTable ()
		{
			NestedClassTable table = m_heap [NestedClassTable.RId] as NestedClassTable;
			if (table != null)
				return table;

			table = new NestedClassTable ();
			InitializeTable (table);
			return table;
		}

		public ParamTable GetParamTable ()
		{
			ParamTable table = m_heap [ParamTable.RId] as ParamTable;
			if (table != null)
				return table;

			table = new ParamTable ();
			InitializeTable (table);
			return table;
		}

		public ParamPtrTable GetParamPtrTable ()
		{
			ParamPtrTable table = m_heap [ParamPtrTable.RId] as ParamPtrTable;
			if (table != null)
				return table;

			table = new ParamPtrTable ();
			InitializeTable (table);
			return table;
		}

		public PropertyTable GetPropertyTable ()
		{
			PropertyTable table = m_heap [PropertyTable.RId] as PropertyTable;
			if (table != null)
				return table;

			table = new PropertyTable ();
			InitializeTable (table);
			return table;
		}

		public PropertyMapTable GetPropertyMapTable ()
		{
			PropertyMapTable table = m_heap [PropertyMapTable.RId] as PropertyMapTable;
			if (table != null)
				return table;

			table = new PropertyMapTable ();
			InitializeTable (table);
			return table;
		}

		public PropertyPtrTable GetPropertyPtrTable ()
		{
			PropertyPtrTable table = m_heap [PropertyPtrTable.RId] as PropertyPtrTable;
			if (table != null)
				return table;

			table = new PropertyPtrTable ();
			InitializeTable (table);
			return table;
		}

		public StandAloneSigTable GetStandAloneSigTable ()
		{
			StandAloneSigTable table = m_heap [StandAloneSigTable.RId] as StandAloneSigTable;
			if (table != null)
				return table;

			table = new StandAloneSigTable ();
			InitializeTable (table);
			return table;
		}

		public TypeDefTable GetTypeDefTable ()
		{
			TypeDefTable table = m_heap [TypeDefTable.RId] as TypeDefTable;
			if (table != null)
				return table;

			table = new TypeDefTable ();
			InitializeTable (table);
			return table;
		}

		public TypeRefTable GetTypeRefTable ()
		{
			TypeRefTable table = m_heap [TypeRefTable.RId] as TypeRefTable;
			if (table != null)
				return table;

			table = new TypeRefTable ();
			InitializeTable (table);
			return table;
		}

		public TypeSpecTable GetTypeSpecTable ()
		{
			TypeSpecTable table = m_heap [TypeSpecTable.RId] as TypeSpecTable;
			if (table != null)
				return table;

			table = new TypeSpecTable ();
			InitializeTable (table);
			return table;
		}

		public override void VisitTableCollection (TableCollection coll)
		{
			WriteCount (ModuleTable.RId);
			WriteCount (TypeRefTable.RId);
			WriteCount (TypeDefTable.RId);
			WriteCount (FieldPtrTable.RId);
			WriteCount (FieldTable.RId);
			WriteCount (MethodPtrTable.RId);
			WriteCount (MethodTable.RId);
			WriteCount (ParamPtrTable.RId);
			WriteCount (ParamTable.RId);
			WriteCount (InterfaceImplTable.RId);
			WriteCount (MemberRefTable.RId);
			WriteCount (ConstantTable.RId);
			WriteCount (CustomAttributeTable.RId);
			WriteCount (FieldMarshalTable.RId);
			WriteCount (DeclSecurityTable.RId);
			WriteCount (ClassLayoutTable.RId);
			WriteCount (FieldLayoutTable.RId);
			WriteCount (StandAloneSigTable.RId);
			WriteCount (EventMapTable.RId);
			WriteCount (EventPtrTable.RId);
			WriteCount (EventTable.RId);
			WriteCount (PropertyMapTable.RId);
			WriteCount (PropertyPtrTable.RId);
			WriteCount (PropertyTable.RId);
			WriteCount (MethodSemanticsTable.RId);
			WriteCount (MethodImplTable.RId);
			WriteCount (ModuleRefTable.RId);
			WriteCount (TypeSpecTable.RId);
			WriteCount (ImplMapTable.RId);
			WriteCount (FieldRVATable.RId);
			WriteCount (AssemblyTable.RId);
			WriteCount (AssemblyProcessorTable.RId);
			WriteCount (AssemblyOSTable.RId);
			WriteCount (AssemblyRefTable.RId);
			WriteCount (AssemblyRefProcessorTable.RId);
			WriteCount (AssemblyRefOSTable.RId);
			WriteCount (FileTable.RId);
			WriteCount (ExportedTypeTable.RId);
			WriteCount (ManifestResourceTable.RId);
			WriteCount (NestedClassTable.RId);
			WriteCount (GenericParamTable.RId);
			WriteCount (MethodSpecTable.RId);
			WriteCount (GenericParamConstraintTable.RId);
		}
	}
}
