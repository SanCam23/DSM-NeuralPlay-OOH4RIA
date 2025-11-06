

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioRepository _IComentarioRepository;

public ComentarioCEN(IComentarioRepository _IComentarioRepository)
{
        this._IComentarioRepository = _IComentarioRepository;
}

public IComentarioRepository get_IComentarioRepository ()
{
        return this._IComentarioRepository;
}

public int New_ (string p_contenido, Nullable<DateTime> p_fechaCreacion, Nullable<DateTime> p_fechaEdicion)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Contenido = p_contenido;

        comentarioEN.FechaCreacion = p_fechaCreacion;

        comentarioEN.FechaEdicion = p_fechaEdicion;



        oid = _IComentarioRepository.New_ (comentarioEN);
        return oid;
}

public void Modify (int p_Comentario_OID, string p_contenido, Nullable<DateTime> p_fechaCreacion, Nullable<DateTime> p_fechaEdicion)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Contenido = p_contenido;
        comentarioEN.FechaCreacion = p_fechaCreacion;
        comentarioEN.FechaEdicion = p_fechaEdicion;
        //Call to ComentarioRepository

        _IComentarioRepository.Modify (comentarioEN);
}

public void Destroy (int id
                     )
{
        _IComentarioRepository.Destroy (id);
}

public ComentarioEN ReadOID (int id
                             )
{
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioRepository.ReadOID (id);
        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> list = null;

        list = _IComentarioRepository.ReadAll (first, size);
        return list;
}
}
}
