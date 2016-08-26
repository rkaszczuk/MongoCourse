package com.example.JavaSpringMongo;

import com.example.JavaSpringMongo.models.Movie;
import com.example.JavaSpringMongo.repository.MovieRepository;
import com.example.JavaSpringMongo.repository.MyMovieRepository;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;


/**
 * Created by Rafał on 2015-02-27.
 */
public class SpringMongoMain {
    @Autowired
    private MovieRepository movieRepository;

    @Autowired
    private MyMovieRepository myMovieRepository;

    public void run() {
        Movie movie = movieRepository.findByName("Harry Potter and the Philosopher's Stone");
        System.out.println(movie);
        List<Movie> myMovies = movieRepository.findByStarringActor("Emma Watson");
        System.out.println("myMovies");
        for (Movie m : myMovies) {
            System.out.println("\t" + m);
        }

        List<Movie> expensiveMovies = movieRepository.findTop3ByEstimatedBudgetAmountGreaterThan(1000000);
        System.out.println("expensiveMovies:");
        for (Movie m : expensiveMovies) {
            System.out.println("\t" + m);
        }

        Movie myMovieByName = myMovieRepository.getByName("Harry Potter and the Philosopher's Stone");
        System.out.println(myMovieByName);
    }
}
