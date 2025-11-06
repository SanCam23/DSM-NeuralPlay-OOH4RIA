

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class ComunidadCEN
 *
 */
public partial class ComunidadCEN
{
private IComunidadRepository _IComunidadRepository;

public ComunidadCEN(IComunidadRepository _IComunidadRepository)
{
        this._IComunidadRepository = _IComunidadRepository;
}

public IComunidadRepository get_IComunidadRepository ()
{
        return this._IComunidadRepository;
}

public int New_ (string p_nombre, string p_descripcion, Nullable<DateTime> p_fechaCreacion, int p_propuestaTorneo)
{
        ComunidadEN comunidadEN = null;
        int oid;

        //Initialized ComunidadEN
        comunidadEN = new ComunidadEN ();
        comunidadEN.Nombre = p_nombre;

        comunidadEN.Descripcion = p_descripcion;

        comunidadEN.FechaCreacion = p_fechaCreacion;


        if (p_propuestaTorneo != -1) {
                // El argumento p_propuestaTorneo -> Property propuestaTorneo es oid = false
                // Lista de oids id
                comunidadEN.PropuestaTorneo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN ();
                comunidadEN.PropuestaTorneo.Id = p_propuestaTorneo;
        }



        oid = _IComunidadRepository.New_ (comunidadEN);
        return oid;
}

public void Modify (int p_Comunidad_OID, string p_nombre, string p_descripcion, Nullable<DateTime> p_fechaCreacion)
{
        ComunidadEN comunidadEN = null;

        //Initialized ComunidadEN
        comunidadEN = new ComunidadEN ();
        comunidadEN.Id = p_Comunidad_OID;
        comunidadEN.Nombre = p_nombre;
        comunidadEN.Descripcion = p_descripcion;
        comunidadEN.FechaCreacion = p_fechaCreacion;
        //Call to ComunidadRepository

        _IComunidadRepository.Modify (comunidadEN);
}

public void Destroy (int id
                     )
{
        _IComunidadRepository.Destroy (id);
}

public ComunidadEN ReadOID (int id
                            )
{
        ComunidadEN comunidadEN = null;

        comunidadEN = _IComunidadRepository.ReadOID (id);
        return comunidadEN;
}

public System.Collections.Generic.IList<ComunidadEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ComunidadEN> list = null;

        list = _IComunidadRepository.ReadAll (first, size);
        return list;
}
}
}
