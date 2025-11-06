

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class EquipoCEN
 *
 */
public partial class EquipoCEN
{
private IEquipoRepository _IEquipoRepository;

public EquipoCEN(IEquipoRepository _IEquipoRepository)
{
        this._IEquipoRepository = _IEquipoRepository;
}

public IEquipoRepository get_IEquipoRepository ()
{
        return this._IEquipoRepository;
}

public int New_ (string p_nombre, string p_descripcion, Nullable<DateTime> p_fechaCreacion, int p_comunidad, System.Collections.Generic.IList<int> p_juego)
{
        EquipoEN equipoEN = null;
        int oid;

        //Initialized EquipoEN
        equipoEN = new EquipoEN ();
        equipoEN.Nombre = p_nombre;

        equipoEN.Descripcion = p_descripcion;

        equipoEN.FechaCreacion = p_fechaCreacion;


        if (p_comunidad != -1) {
                // El argumento p_comunidad -> Property comunidad es oid = false
                // Lista de oids id
                equipoEN.Comunidad = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN ();
                equipoEN.Comunidad.Id = p_comunidad;
        }


        equipoEN.Juego = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN>();
        if (p_juego != null) {
                foreach (int item in p_juego) {
                        NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN en = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN ();
                        en.Id = item;
                        equipoEN.Juego.Add (en);
                }
        }

        else{
                equipoEN.Juego = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN>();
        }



        oid = _IEquipoRepository.New_ (equipoEN);
        return oid;
}

public void Modify (int p_Equipo_OID, string p_nombre, string p_descripcion, Nullable<DateTime> p_fechaCreacion)
{
        EquipoEN equipoEN = null;

        //Initialized EquipoEN
        equipoEN = new EquipoEN ();
        equipoEN.Id = p_Equipo_OID;
        equipoEN.Nombre = p_nombre;
        equipoEN.Descripcion = p_descripcion;
        equipoEN.FechaCreacion = p_fechaCreacion;
        //Call to EquipoRepository

        _IEquipoRepository.Modify (equipoEN);
}

public void Destroy (int id
                     )
{
        _IEquipoRepository.Destroy (id);
}

public EquipoEN ReadOID (int id
                         )
{
        EquipoEN equipoEN = null;

        equipoEN = _IEquipoRepository.ReadOID (id);
        return equipoEN;
}

public System.Collections.Generic.IList<EquipoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EquipoEN> list = null;

        list = _IEquipoRepository.ReadAll (first, size);
        return list;
}
}
}
