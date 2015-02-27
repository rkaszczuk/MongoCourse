package com.example.JavaSpringMongo;

import com.example.JavaSpringMongo.models.User;
import com.example.JavaSpringMongo.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;


/**
 * Created by Rafał on 2015-02-27.
 */
public class SpringMongoMain {
    @Autowired
    private UserRepository userRepository;

    public void run(){
        userRepository.save(new User("BenSpring", 42));
        System.out.println(userRepository.findByName("BenSpring"));
    }
}
