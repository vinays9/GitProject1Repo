pipeline{
    agent any
    stages{
        stage('Deploy to Development server'){
            steps{
               build 'WebApplication1-Develop'
            }
        }
        stage('Deploy to Testing server'){
            steps{
               build 'WebApplication-Stage'
            }
        }
    }
}