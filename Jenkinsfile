pipeline{
    agent any
    stages{
        stage('Deploy to Development server'){
            steps{
               build 'WebApplication1-Develop'
            }
        }
		stage('Approve?')
		{
			steps{
				timeout(time:2, unit:'DAYS')
				{
					input message: 'Can you approve this ??', submitter: 'vinay'
				}
			}
		}
        stage('Deploy to Testing server'){
            steps{
               build 'WebApplication-Stage'
            }
        }
    }
}