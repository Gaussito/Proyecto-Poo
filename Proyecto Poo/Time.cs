using System;

public class Time
{
    private int horas;
    private int minutos;
    private int segundos;
    private int milisegundos;

    // Constructor sin parámetros
    public Time()
    {
        horas = 0;
        minutos = 0;
        segundos = 0;
        milisegundos = 0;
    }

    // Constructor con horas
    public Time(int horas)
    {
        if (horas < 0 || horas > 23)
        {
            throw new ArgumentOutOfRangeException(
                "horas",
                "Las horas deben estar entre 0 y 23."
            );
        }

        this.horas = horas;
        this.minutos = 0;
        this.segundos = 0;
        this.milisegundos = 0;
    }

    // Constructor con horas y minutos
    public Time(int horas, int minutos)
    {
        if (horas < 0 || horas > 23)
        {
            throw new ArgumentOutOfRangeException(
                "horas",
                "Las horas deben estar entre 0 y 23."
            );
        }

        if (minutos < 0 || minutos > 59)
        {
            throw new ArgumentOutOfRangeException(
                "minutos",
                "Los minutos deben estar entre 0 y 59."
            );
        }

        this.horas = horas;
        this.minutos = minutos;
        this.segundos = 0;
        this.milisegundos = 0;
    }

    // Constructor con horas, minutos y segundos
    public Time(int horas, int minutos, int segundos)
    {
        if (horas < 0 || horas > 23)
        {
            throw new ArgumentOutOfRangeException(
                "horas",
                "Las horas deben estar entre 0 y 23."
            );
        }

        if (minutos < 0 || minutos > 59)
        {
            throw new ArgumentOutOfRangeException(
                "minutos",
                "Los minutos deben estar entre 0 y 59."
            );
        }

        if (segundos < 0 || segundos > 59)
        {
            throw new ArgumentOutOfRangeException(
                "segundos",
                "Los segundos deben estar entre 0 y 59."
            );
        }

        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos;
        this.milisegundos = 0;
    }

    // Constructor con horas, minutos, segundos y milisegundos
    public Time(int horas, int minutos, int segundos, int milisegundos)
    {
        if (horas < 0 || horas > 23)
        {
            throw new ArgumentOutOfRangeException(
                "horas",
                "Las horas deben estar entre 0 y 23."
            );
        }

        if (minutos < 0 || minutos > 59)
        {
            throw new ArgumentOutOfRangeException(
                "minutos",
                "Los minutos deben estar entre 0 y 59."
            );
        }

        if (segundos < 0 || segundos > 59)
        {
            throw new ArgumentOutOfRangeException(
                "segundos",
                "Los segundos deben estar entre 0 y 59."
            );
        }

        if (milisegundos < 0 || milisegundos > 999)
        {
            throw new ArgumentOutOfRangeException(
                "milisegundos",
                "Los milisegundos deben estar entre 0 y 999."
            );
        }

        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos;
        this.milisegundos = milisegundos;
    }

    // Retorna la hora en formato HH:MM:ss.mmm tt
    public override string ToString()
    {
        int hora;
        string periodo;

        if (horas == 0)
        {
            hora = 0;
            periodo = "AM";
        }
        else if (horas < 12)
        {
            hora = horas;
            periodo = "AM";
        }
        else if (horas == 12)
        {
            hora = 12;
            periodo = "PM";
        }
        else
        {
            hora = horas - 12;
            periodo = "PM";
        }

        return $"{hora:00}:{minutos:00}:{segundos:00}.{milisegundos:000} {periodo}";
    }

    // Retorna los milisegundos desde 00:00:00.000
    public long ToMilliseconds()
    {
        return horas * 3600000L
             + minutos * 60000L
             + segundos * 1000L
             + milisegundos;
    }

    // Retorna los segundos desde 00:00:00
    public long ToSeconds()
    {
        return horas * 3600L
             + minutos * 60L
             + segundos;
    }

    // Retorna los minutos desde 00:00
    public long ToMinutes()
    {
        return horas * 60L + minutos;
    }

    // Verifica si la suma pasa al siguiente día
    public bool IsOtherDay(Time otro)
    {
        int totalMilisegundos = milisegundos + otro.milisegundos;
        int totalSegundos = segundos + otro.segundos;
        int totalMinutos = minutos + otro.minutos;
        int totalHoras = horas + otro.horas;

        if (totalMilisegundos >= 1000)
        {
            totalSegundos++;
        }

        if (totalSegundos >= 60)
        {
            totalMinutos++;
        }

        if (totalMinutos >= 60)
        {
            totalHoras++;
        }

        return totalHoras >= 24;
    }

    // Suma dos objetos Time
    public Time Add(Time otro)
    {
        int totalMilisegundos = milisegundos + otro.milisegundos;
        int totalSegundos = segundos + otro.segundos;
        int totalMinutos = minutos + otro.minutos;
        int totalHoras = horas + otro.horas;

        // Milisegundos
        if (totalMilisegundos >= 1000)
        {
            totalMilisegundos -= 1000;
            totalSegundos++;
        }

        // Segundos
        if (totalSegundos >= 60)
        {
            totalSegundos -= 60;
            totalMinutos++;
        }

        // Minutos
        if (totalMinutos >= 60)
        {
            totalMinutos -= 60;
            totalHoras++;
        }

        // Si pasa al siguiente día
        if (totalHoras >= 24)
        {
            totalHoras -= 24;
        }

        return new Time(
            totalHoras,
            totalMinutos,
            totalSegundos,
            totalMilisegundos
        );
    }
}