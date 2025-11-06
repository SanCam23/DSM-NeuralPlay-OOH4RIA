

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class PublicacionCEN
 *
 */
public partial class PublicacionCEN
{
private IPublicacionRepository _IPublicacionRepository;

public PublicacionCEN(IPublicacionRepository _IPublicacionRepository)
{
        this._IPublicacionRepository = _IPublicacionRepository;
}

public IPublicacionRepository get_IPublicacionRepository ()
{
        return this._IPublicacionRepository;
}

public int New_ (string p_contenido, Nullable<DateTime> p_fechaCreacion, Nullable<DateTime> p_fechaEdicion, int p_comunidad, int p_usuario)
{
        PublicacionEN publicacionEN = null;
        int oid;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Contenido = p_contenido;

        publicacionEN.FechaCreacion = p_fechaCreacion;

        publicacionEN.FechaEdicion = p_fechaEdicion;


        if (p_comunidad != -1) {
                // El argumento p_comunidad -> Property comunidad es oid = false
                // Lista de oids id
                publicacionEN.Comunidad = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN ();
                publicacionEN.Comunidad.Id = p_comunidad;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                publicacionEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                publicacionEN.Usuario.Id = p_usuario;
        }



        oid = _IPublicacionRepository.New_ (publicacionEN);
        return oid;
}

public void Modify (int p_Publicacion_OID, string p_contenido, Nullable<DateTime> p_fechaCreacion, Nullable<DateTime> p_fechaEdicion)
{
        PublicacionEN publicacionEN = null;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Id = p_Publicacion_OID;
        publicacionEN.Contenido = p_contenido;
        publicacionEN.FechaCreacion = p_fechaCreacion;
        publicacionEN.FechaEdicion = p_fechaEdicion;
        //Call to PublicacionRepository

        _IPublicacionRepository.Modify (publicacionEN);
}

public void Destroy (int id
                     )
{
        _IPublicacionRepository.Destroy (id);
}

public PublicacionEN ReadOID (int id
                              )
{
        PublicacionEN publicacionEN = null;

        publicacionEN = _IPublicacionRepository.ReadOID (id);
        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> list = null;

        list = _IPublicacionRepository.ReadAll (first, size);
        return list;
}
}
}
