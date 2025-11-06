

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class SesionCEN
 *
 */
public partial class SesionCEN
{
private ISesionRepository _ISesionRepository;

public SesionCEN(ISesionRepository _ISesionRepository)
{
        this._ISesionRepository = _ISesionRepository;
}

public ISesionRepository get_ISesionRepository ()
{
        return this._ISesionRepository;
}

public int New_ (Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin, string p_token, int p_usuario)
{
        SesionEN sesionEN = null;
        int oid;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.FechaInicio = p_fechaInicio;

        sesionEN.FechaFin = p_fechaFin;

        sesionEN.Token = p_token;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                sesionEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                sesionEN.Usuario.Id = p_usuario;
        }



        oid = _ISesionRepository.New_ (sesionEN);
        return oid;
}

public void Modify (int p_Sesion_OID, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin, string p_token)
{
        SesionEN sesionEN = null;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.Id = p_Sesion_OID;
        sesionEN.FechaInicio = p_fechaInicio;
        sesionEN.FechaFin = p_fechaFin;
        sesionEN.Token = p_token;
        //Call to SesionRepository

        _ISesionRepository.Modify (sesionEN);
}

public void Destroy (int id
                     )
{
        _ISesionRepository.Destroy (id);
}

public SesionEN ReadOID (int id
                         )
{
        SesionEN sesionEN = null;

        sesionEN = _ISesionRepository.ReadOID (id);
        return sesionEN;
}

public System.Collections.Generic.IList<SesionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SesionEN> list = null;

        list = _ISesionRepository.ReadAll (first, size);
        return list;
}
}
}
