package com.example.JavaSpringMongo.repository;

import com.example.JavaSpringMongo.models.Actor;
import org.springframework.data.repository.Repository;

import java.util.List;

/**
 * Created by Rafał on 2015-02-26.
 */
public interface ActorRepository extends Repository<Actor, String>
{
    public Actor findByName(String name);
    public List<Actor> findTop10ByName();
    //public List<Actor> findByMoviesName(String movieName);
    public List<Actor> findByMovies_MovieName(String movieName);
}
