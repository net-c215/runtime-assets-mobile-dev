//
// ReflectionController.cs
//
// Author:
//   Jb Evain (jbevain@gmail.com)
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

namespace CilStrip.Mono.Cecil {

	internal sealed class ReflectionController {

		ReflectionReader m_reader;
		ReflectionWriter m_writer;
		ReflectionHelper m_helper;
		DefaultImporter m_importer;

		public ReflectionReader Reader {
			get { return m_reader; }
		}

		public ReflectionWriter Writer {
			get { return m_writer; }
		}

		public ReflectionHelper Helper {
			get { return m_helper; }
		}

		public IImporter Importer {
			get { return m_importer; }
		}

		public ReflectionController (ModuleDefinition module)
		{
			m_reader = new AggressiveReflectionReader (module);
			m_writer = new ReflectionWriter (module);
			m_helper = new ReflectionHelper (module);
			m_importer = new DefaultImporter (module);
		}
	}
}
